using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GeneralAccess.Core.Database;
using GeneralAccess.Core.Interfaces;
using GeneralAccess.Entities;
using GeneralAccess.Framework.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GeneralAccess.WebApi.Controllers
{
    [Route("api/authicons")]
    [ApiController]
    public class AuthIconController : ControllerBase
    {
        private readonly IAuthIconRepository authIconRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly ILogger<AuthIconController> logger;
        private readonly IMapper mapper;

        public AuthIconController(IAuthIconRepository authIconRepository,
            IUnitOfWork unitOfWork,
            ILogger<AuthIconController> logger,
            IMapper mapper)
        {
            this.authIconRepository = authIconRepository;
            this.unitOfWork = unitOfWork;
            this.logger = logger;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var authicons = await authIconRepository.GetAllAuthIconsAsync();

            var iconResources = mapper.Map<IEnumerable<AuthIcon>, IEnumerable<IconResources>>(authicons);
            logger.LogInformation("Get All AuthIcon");
            return Ok(iconResources);
        }

        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var newAuthIcon = new AuthIcon()
            {
                IconCode = "Icon_5",
                Description = "Description_Icon_5",
                CreatedOn = DateTime.Now
            };
            authIconRepository.AddAuthIcon(newAuthIcon);
            await unitOfWork.SaveAsync();
            return Ok();
        }
    }
}