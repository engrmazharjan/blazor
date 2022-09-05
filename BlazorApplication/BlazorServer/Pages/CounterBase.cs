using Microsoft.AspNetCore.Components;

namespace BlazorServer.Pages
{
    public class CounterBase:ComponentBase

    {
        protected int currentCount = 0;
        protected string fontFamily = "Verdana";

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}
