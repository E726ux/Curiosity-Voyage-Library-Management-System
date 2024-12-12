using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Curiosity_Voyage_Library_Management_System_1;

public class FormModel : PageModel
{
    private readonly ILogger<FormModel> _logger;
    
    public string FirstName {get; set;} = string.Empty;
    public string LastName {get; set;} = string.Empty;

    public FormModel(ILogger<FormModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            _logger.LogWarning("OnPost() Invalid Model State. Returning to previous page.");
            return Page();
        }

        _logger.LogInformation($"OnPost() Valid Model - {FirstName} {LastName}");
        return Page();
    }

    [BindProperty]
[Display(Name = "First Name")]
[StringLength(30, MinimumLength = 3)]
[Required]
public string Name {get; set;} = string.Empty;

[BindProperty]
[Display(Name = "Last Name")]
[StringLength(30, MinimumLength = 3)]
[Required]
public string Names {get; set;} = string.Empty;
}