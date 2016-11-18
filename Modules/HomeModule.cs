using Nancy;
using GoFish.Objects;
using System;
using System.Collections.Generic;

namespace GoFish
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                Deck newDeck = new Deck();
                return View["index.cshtml"];
            };
        }
    }
}
