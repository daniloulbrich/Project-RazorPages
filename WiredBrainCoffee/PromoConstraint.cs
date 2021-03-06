using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WiredBrainCoffee
{
    public class PromoConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            int letterCount = 0;
            int numCount = 0;
            int suma = 0;

            foreach (var unit in values["token"].ToString())
            {
                letterCount += Char.IsLetter(unit) ? 1 : 0;
                numCount += Char.IsDigit(unit) ? 1 : 0;
                suma += Char.IsDigit(unit) ? int.Parse(unit.ToString()) : 0;
            }

            return letterCount == 3 && numCount == 3 && suma % 3 == 0;
        }
    }
}
