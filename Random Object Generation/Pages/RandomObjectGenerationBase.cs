using Microsoft.AspNetCore.Http;
using Random_Object_Generation.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Random_Object_Generation.Pages
{
    public class RandomObjectGenerationBase: Microsoft.AspNetCore.Components.ComponentBase
    {
        public IEnumerable<RandomObject> randomObjects;
        private bool Generate=false;
        private int RandomObjectCount = 3;
        public long FileSizeInKB = 1;
        private string OutFileName = "randomObject.txt";
        public bool AllDisabled = false;
        //private readonly IHttpContextAccessor _httpContextAccessor;
        //public HttpContext Context => _httpContextAccessor.HttpContext;

        //public RandomObjectGenerationBase(IHttpContextAccessor httpContextAccessor)
        //{
        //    _httpContextAccessor = httpContextAccessor;
        //}

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(IntializeRandomObject);
        }

        private void IntializeRandomObject()
        {
            double PercentageEach = 100.0 / RandomObjectCount;
            randomObjects = new List<RandomObject>{
                new NumericRandomObject(PercentageEach),
                new AlphaNumericRandomObject(PercentageEach),
                new FloatRandomObject(PercentageEach)
            };
        }

        public async void StartGenerating()
        {
            if(AllDisabled)
                return;

            _ = Task.Run(async() =>
              {
                  Generate = true;
                  long currentFileSize = 0;
                  if (File.Exists(OutFileName))
                  {
                      File.Delete(OutFileName);
                  }
                  using (StreamWriter outFile=File.AppendText(OutFileName))
                  {
                      while (Generate && currentFileSize < FileSizeInKB*1024)
                      {
                          int rindex = new Random().Next(RandomObjectCount);
                          RandomObject ro = randomObjects.ElementAt(rindex);
                          if (!ro.IsEnable) continue;
                          _ = InvokeAsync(() =>
                            {
                                if (ro.GenerateNext())
                                {
                                    outFile.WriteAsync(ro.LastGeneratedObject + ",");
                                    currentFileSize += 4;
                                    StateHasChanged();
                                    currentFileSize = new FileInfo(OutFileName).Length;
                                }
                            });

                          Thread.Sleep(100);
                      }

                  }

                  Generate = false;

              });
        }
        public void StopGenerating()
        { 
            Generate = false;
        }


    }
}
