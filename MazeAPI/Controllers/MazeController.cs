﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MazeAPI.Models;

namespace MazeAPI.Controllers
{
    [Route("api/[controller]")]
    public class MazeController : Controller
    {
        // GET api/maze/<width>/<height>
        [HttpGet("{width}x{height}?seed={seedStr}")]
        public Maze Get(int width, int height, string seedStr)
        {
            int.TryParse(seedStr, out int seed);

            Maze maze = Maze.Generate(seed, width, height);
            return maze;
        }
    }
}
