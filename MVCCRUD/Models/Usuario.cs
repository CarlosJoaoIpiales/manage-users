using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCCRUD.Models;

public partial class Usuario
{
    public int Id { get; set; }

    // Controller for what user not enter numbers in the textarea for just names
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo debe contener letras.")]
    public string? Nombre { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Clave { get; set; }


    
}
