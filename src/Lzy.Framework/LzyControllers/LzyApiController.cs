using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lzy.Framework.LzyControllers;

public class LzyApiController : ControllerBase
{
    [NonAction]
    public IActionResult Success()
    {
        return Ok();
    }
}