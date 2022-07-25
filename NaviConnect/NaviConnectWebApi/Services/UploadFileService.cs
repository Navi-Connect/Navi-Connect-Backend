using Microsoft.AspNetCore.Mvc;
using NaviConnectWebApi.Models;

namespace NaviConnectWebApi.Services;

public class UploadFileService
{
    public static IWebHostEnvironment _environment;

    public UploadFileService(IWebHostEnvironment environment)
    {
        _environment = environment;
    }
    // public async void Upload(string path, string fileName, IFormFile file)
    // {
    //     using var stream = new FileStream(Path.Combine(path, fileName), FileMode.Create);
    //     await file.CopyToAsync(stream);
    // } 
    
    public async Task<string> Upload([FromForm] UserRegisterRequest objFile)
    {
        try
        {
            if (objFile.File.Length > 0)
            {
                if (!Directory.Exists(_environment.WebRootPath + "\\images\\"))
                {
                    Directory.CreateDirectory(_environment.WebRootPath + "\\images\\");
                }

                using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\images\\"+objFile.File.FileName))
                {
                    objFile.File.CopyTo(fileStream);
                    fileStream.Flush();
                    return "\\images\\" + objFile.File.FileName;
                }
            }
            else
            {
                return "Failed !!!";
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
    }
}