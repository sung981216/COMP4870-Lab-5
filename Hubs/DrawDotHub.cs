using System;
using System.Drawing;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

public class DrawDotHub: Hub {

    Random rnd = new Random();
   public async Task UpdateCanvas(int x, int y) {
      await Clients.All.SendAsync("updateDot",x, y);
   }

   public async Task ClearCanvas() {
      await Clients.All.SendAsync("clearCanvas");
   }
}
