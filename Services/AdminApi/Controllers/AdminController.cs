﻿
using CommonLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace AdminApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet("Users")]
        public async Task<ActionResult<ResponseDTO>> GetUsers()
        {
            var client = _httpClientFactory.CreateClient();
            var userApiURL = "https://localhost:7021/api/Users";
            var response = await client.GetStringAsync(userApiURL);
             

            ResponseDTO responseDTO = new()
            {
                Result =  JsonConvert.DeserializeObject<List<UserDTO>>(response),
                IsSuccessful = true
            };

            return Ok(responseDTO);
        }
    }
}
