using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboards.Models
{
    // Applies to Wearable only
    public enum Category
    {
        Cap = 1,
        Hoodie,
        Tshirt,

    }

    public enum Color
    {
        Blue,
        Black,
        Green,
        Grey,
        Patterned,
        Pink,
        Purple,
        Red,
        White,
        Yellow
    }

    // Applies to Wearable only
    public enum Size
    {
        [Display(Name = "ONE SIZE")]
        ONE_SIZE,
        S,
        M, 
        L
    }

    // Applies to Skatebords only
    public enum Material 
    {
        Plastic,
        Wood
    }

    // Applies to Wheels only
    public enum WheelSize
    {
        Fat,
        Slim
    }
}
