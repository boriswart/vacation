using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using vacation.Models;
using vacation.Services;
using CodeWorks.Auth0Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace vacation.Controllers
{
  [ApiController]
  [Route("/api/[controller]")]
  public class AccountController : ControllerBase
  {
    private readonly AccountService _accountService;

    public AccountController(AccountService accountService)
    {
      _accountService = accountService;
    }

    [HttpGet]
    [Authorize]
    public async Task<ActionResult<Account>> Get()
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        return Ok(_accountService.GetOrCreateProfile(userInfo));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }


}