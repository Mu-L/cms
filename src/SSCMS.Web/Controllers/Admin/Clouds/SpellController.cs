﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using SSCMS.Configuration;
using SSCMS.Repositories;
using SSCMS.Services;

namespace SSCMS.Web.Controllers.Admin.Clouds
{
    [OpenApiIgnore]
    [Authorize(Roles = Types.Roles.Administrator)]
    [Route(Constants.ApiAdminPrefix)]
    public partial class SpellController : ControllerBase
    {
        private const string Route = "clouds/spell";

        private readonly IAuthManager _authManager;
        private readonly IConfigRepository _configRepository;

        public SpellController(
            IAuthManager authManager, 
            IConfigRepository configRepository
        )
        {
            _authManager = authManager;
            _configRepository = configRepository;
        }

        public class GetResult
        {
            public bool IsCloudSpellingCheck { get; set; }
            public bool IsCloudSpellingCheckAuto { get; set; }
            public bool IsCloudSpellingCheckIgnore { get; set; }
            public bool IsCloudSpellingCheckWhiteList { get; set; }
        }

        public class SubmitRequest
        {
            public bool IsCloudSpellingCheck { get; set; }
            public bool IsCloudSpellingCheckAuto { get; set; }
            public bool IsCloudSpellingCheckIgnore { get; set; }
            public bool IsCloudSpellingCheckWhiteList { get; set; }
        }
    }
}
