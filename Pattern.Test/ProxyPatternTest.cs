﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern.ProxyPattern;
using Xunit;
using Xunit.Extensions;
using Xunit.Should;

namespace Pattern.Test
{
    public class ProxyPatternTest
    {
        [Fact]
        public void Test()
        {
            Booking booking = new Ctrip();
            Booking railway = new RailwayStation();

            Assert.Equal(railway.BuyTicket(), booking.BuyTicket());
        }
    }
}
