using System;
using System.Collections;
using System.Collections.Generic;
using EduHome_BE.Models;

namespace EduHome_BE.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<PageIntro> PageIntros { get; set; }
    }
}
