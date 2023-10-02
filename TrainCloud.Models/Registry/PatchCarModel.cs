using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainCloud.Models.Registry;
public class PatchCarModel : IValidatableObject
{
    [Required]
    public string FullUIC { get; set; } = string.Empty;


    public string? VKMCode { get; set; }

    public string? VKM { get; set; }

    [Required]
    public decimal? LengthOverBuffers { get; set; }

    public decimal? TareWeight { get; set; }

    public decimal? MaximumPayload { get; set; }

    public decimal? BruttoWeight { get; set; }

    [Required]
    public decimal? NumberOfWheels { get; set; }

    public decimal? RadiusMinimum { get; set; }

    public string? TypeOfBrakes { get; set; }

    [Required]
    public string? BreakShoeSole { get; set; }

    public string? SpecialBrakeType { get; set; }

    public decimal? HandbrakeWeightFreightCar { get; set; }

    public decimal? HandbrakeForceFreightCar { get; set; }

    public decimal? ConversionWeightFreightWagon { get; set; }

    public decimal? BrakeWeightFreightCarEmpty { get; set; }

    public decimal? BrakeWeightFreightCarLoaded { get; set; }

    [Required]
    public bool DangerousGoodsCar { get; set; }

    public string? ECMMail { get; set; }

    public string? FreightCarCategory { get; set; }

    public string? ReferenceProfile { get; set; }

    public string? RMin { get; set; }

    public decimal? BrakeRPlusE160 { get; set; }

    public decimal? BrakeRPlusE { get; set; }

    public decimal? BrakeR { get; set; }

    public decimal? BrakePPlusE { get; set; }

    public decimal? BrakeP2 { get; set; }

    public decimal? BrakeP { get; set; }

    public decimal? BrakeG { get; set; }

    public decimal? BrakeRPlusMgrot { get; set; }

    public decimal? BrakeRplusMg { get; set; }

    public decimal? BrakeRrot { get; set; }

    public decimal? BrakePplusMgRot { get; set; }

    public decimal? BrakePPlusMg { get; set; }

    public decimal? BrakeProt { get; set; }

    public decimal? BrakeGrot { get; set; }

    public string? CarComment { get; set; }

    [Required]
    public string RevisionComment { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (NumberOfWheels == 2 && TareWeight <= 10000)
        {
            yield return new ValidationResult("Leergewicht zu gering");
        }
        if (NumberOfWheels == 4 && TareWeight <= 12000)
        {
            yield return new ValidationResult("Leergewicht zu gering");
        }
        if (NumberOfWheels == 6 && TareWeight <= 15000)
        {
            yield return new ValidationResult("Leergewicht zu gering");
        }
        if (NumberOfWheels == 8 && TareWeight <= 17000)
        {
            yield return new ValidationResult("Leergewicht zu gering");
        }
        var calcBrutto = TareWeight + MaximumPayload;
        if (NumberOfWheels == 2 && calcBrutto > 50000)
        {
            yield return new ValidationResult("Zuladung zu groß");
        }
        if (NumberOfWheels == 4 && calcBrutto > 100000)
        {
            yield return new ValidationResult("Zuladung zu groß");
        }
        if (NumberOfWheels == 6 && calcBrutto > 150000)
        {
            yield return new ValidationResult("Zuladung zu groß");
        }
        if (NumberOfWheels == 8 && calcBrutto > 200000)
        {
            yield return new ValidationResult("Zuladung zu groß");
        }

        if (NumberOfWheels == 2 && BruttoWeight > 50000)
        {
            yield return new ValidationResult("Maximalgewicht zu groß");
        }
        if (NumberOfWheels == 4 && BruttoWeight > 100000)
        {
            yield return new ValidationResult("Maximalgewicht zu groß");
        }
        if (NumberOfWheels == 6 && BruttoWeight > 150000)
        {
            yield return new ValidationResult("Maximalgewicht zu groß");
        }
        if (NumberOfWheels == 8 && BruttoWeight > 200000)
        {
            yield return new ValidationResult("Zuladung zu groß");
        }
        if (TareWeight > BruttoWeight)
        {
            yield return new ValidationResult("Leergewicht > Maximalgewicht");
        }
        if (TareWeight > MaximumPayload)
        {
            yield return new ValidationResult("Leergewicht > maximale Zuladung");
        }
        if (MaximumPayload > BruttoWeight)
        {
            yield return new ValidationResult("maximale Zuladung > Maximalgewicht");
        }

        
        if (BrakeWeightFreightCarEmpty > ConversionWeightFreightWagon)
        {
            yield return new ValidationResult("Bremsgewicht leer > Umstellgewicht");
        }
        if (BrakeWeightFreightCarEmpty > BrakeWeightFreightCarLoaded)
        {
            yield return new ValidationResult("Bremsgewicht leer > Bremsgewicht beladen");
        }
        if (ConversionWeightFreightWagon > BrakeWeightFreightCarLoaded)
        {
            yield return new ValidationResult("Umstellgewicht > Bremsgewicht beladen");
        }

            
        if (BrakeG > BrakeP)
        {
            yield return new ValidationResult("G [t] > P [t]");
        }
        if (BrakeG > BrakeP2)
        {
            yield return new ValidationResult("G [t] > P2 [t]");
        }
        if (BrakeG > BrakeR)
        {
            yield return new ValidationResult("G [t] > R [t]");
        }
        if (BrakeG > BrakePPlusE)
        {
            yield return new ValidationResult("G [t] > P + E [t]");
        }
        if (BrakeG > BrakeRPlusE)
        {
            yield return new ValidationResult("G [t] > R + E [t]");
        }
        if (BrakeG > BrakeRPlusE160)
        {
            yield return new ValidationResult("G [t] > R + E160 [t]");
        }
        if (BrakeP > BrakeP2)
        {
            yield return new ValidationResult("P [t] > P2 [t]");
        }
        if (BrakeP > BrakeR)
        {
            yield return new ValidationResult("P [t] > R [t]");
        }
        if (BrakeP > BrakePPlusE)
        {
            yield return new ValidationResult("P [t] > P + E [t]");
        }
        if (BrakeP > BrakeRPlusE)
        {
            yield return new ValidationResult("P [t] > R + E [t]");
        }
        if (BrakeP > BrakeRPlusE160)
        {
            yield return new ValidationResult("P [t] > R + E160 [t]");
        }
        if (BrakeP2 > BrakeR)
        {
            yield return new ValidationResult("P2 [t] > R [t]");
        }
        if (BrakeP2 > BrakePPlusE)
        {
            yield return new ValidationResult("P2 [t] > P + E [t]");
        }
        if (BrakeP2 > BrakeRPlusE)
        {
            yield return new ValidationResult("P2 [t] > R + E [t]");
        }
        if (BrakeP2 > BrakeRPlusE160)
        {
            yield return new ValidationResult("P2 [t] > R + E160 [t]");
        }
        if (BrakeR > BrakeRPlusE)
        {
            yield return new ValidationResult("R [t] > R + E [t]");
        }
        if (BrakeR > BrakeRPlusE160)
        {
            yield return new ValidationResult("R [t] > R + E160 [t]");
        }
        if (BrakePPlusE > BrakeRPlusE)
        {
            yield return new ValidationResult("P + E [t] > R + E [t]");
        }
        if (BrakePPlusE > BrakeRPlusE160)
        {
            yield return new ValidationResult("P + E [t] > R + E160 [t]");
        }
        if (BrakeRPlusE > BrakeRPlusE160)
        {
            yield return new ValidationResult("R + E [t] > R + E160 [t]");
        }

        yield return ValidationResult.Success;
    }
}
