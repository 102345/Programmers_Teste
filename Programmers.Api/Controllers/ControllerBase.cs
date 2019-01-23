﻿using System.Diagnostics;
using System.Web.Http;
using Programmers.Business.ViewModels;

namespace Programmers.Api.Controllers
{
    public class ControllerBase : ApiController
    {
        private Stopwatch _stopWatch;
        private JsonViewModel _jsonResult;

        public Stopwatch StopWatch
        {
            get
            {
                return _stopWatch;
            }
            set
            {
                _stopWatch = value;
            }
        }
        public JsonViewModel JsonResult
        {
            get
            {
                return _jsonResult;
            }
            set
            {
                _jsonResult = value;
            }
        }

        public ControllerBase()
        {
            _stopWatch = new Stopwatch();
            _jsonResult = new JsonViewModel();
        }
    }
}
