using Cyberpolygon.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Cyberpolygon.Pages
{
    public class SettingsModel : PageModel
    {
        public IActionResult OnPutConfigurationContext([FromBody] ConfigurationContextModel model)
        {
            try
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
                var json = System.IO.File.ReadAllText(filePath);
                dynamic jsonObj = JsonConvert.DeserializeObject(json);

                jsonObj["ConnectionStrings"]["ConfigurationContext"] = model.ConfigurationContext;

                string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                System.IO.File.WriteAllText(filePath, output);

                // Создаем базу данных, если она не существует
                using (var db = new ConfigurationContext(new DbContextOptionsBuilder<ConfigurationContext>().UseSqlServer(model.ConfigurationContext).Options))
                {
                    db.EnsureCreatedIfNotExists();
                }

                return new OkResult();
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Произошла ошибка при сохранении значений.");
            }
        }

        public class ConfigurationContextModel
        {
            public string ConfigurationContext { get; set; }
        }

        public void OnGet()
        {
        }
    }
}
