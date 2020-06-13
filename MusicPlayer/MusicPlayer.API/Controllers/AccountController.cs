﻿using System.Threading.Tasks;
using MusicPlayer.BLL.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using MusicPlayer.BLL.DTOs;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace MusicPlayer.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IAccountService accountService;
        private readonly JWT jwt;

        public AccountController(IAccountService accountService,
            JWT jwt)
        {
            this.accountService = accountService;
            this.jwt = jwt;
        }

        /// <summary>
        /// Register
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("Register")]
        public async Task<ActionResult<UserDTO>> RegisterUser([FromBody]UserDTO userDTO)
        {
            if (!await accountService.IsEmailUniqueAsync(userDTO.Email))
            {
                ModelState.AddModelError("Email", "Email вже використовується");
            }

            if (!await accountService.IsUserNameUniqueAsync(userDTO.UserName))
            {
                ModelState.AddModelError("UserName", "Дане ім'я вже використовується");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await accountService.CreateUserAsync(userDTO);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return BadRequest(ModelState);
            }

            return Ok();
        }

        /// <summary>
        /// Log in
        /// </summary>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public async Task<IActionResult> Authenticate([FromBody]UserLoginDTO userDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await accountService.AuthenticateUserAsync(userDTO);

            if (result != null && result.Succeeded)
            {
                var user = await accountService.GetUserByEmailAsync(userDTO.Email);
                return Ok(new
                {
                    id = user.Id,
                    Username = user.UserName,
                    Token = jwt.GenerateJwtToken(user.Email, user)
                });
            }

            ModelState.AddModelError(string.Empty, "Invalid Login or Password");
            return BadRequest(ModelState);
        }

        /// <summary>
        /// GetAll
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> Get()
        {
            var userDTOList = await accountService.GetAllUsersAsync();

            if (userDTOList == null)
            {
                return NotFound();
            }

            return Ok(userDTOList);
        }

        /// <summary>
        /// GetForUpdateById
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("Update/{Id}")]
        public async Task<ActionResult<UserUpdateDTO>> GetForUpdate(string Id)
        {
            if (Id == null)
            {
                return BadRequest();
            }

            var userDTO = await accountService.GetUserForUpdateAsync(Id);

            if (userDTO == null)
            {
                return NotFound();
            }

            return Ok(userDTO);
        }

        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userDTO"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(string id, [FromBody]UserUpdateDTO userDTO)
        {
            if (id == null || userDTO == null)
            {
                return BadRequest();
            }

            if (!await accountService.IsEmailUniqueAsync(userDTO.Email))
            {
                ModelState.AddModelError("Email", "Email вже використовується");
            }

            if (!await accountService.IsUserNameUniqueAsync(userDTO.UserName))
            {
                ModelState.AddModelError("UserName", "Дане ім'я вже використовується");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await accountService.UpdateUserAsync(id, userDTO);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return BadRequest(ModelState);
                }

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message });
            }
        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            await accountService.DeleteUserAsync(id);
            return Ok();
        }

        /// <summary>
        /// Logout
        /// </summary>
        /// <returns></returns>
        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            await accountService.SignOutUserAsync();
            return Ok();
        }
    }
}
