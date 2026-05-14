using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SkillBridge.Api.Entities;

public class Job
{
    [Required, Key]
    public int Id {get;set;}
    [Required]
    public string Title {get;set;}
    [Required]
    public string Description {get;set;}
    [Required]
    public string Company {get;set;}
    [Required]
    public string Location {get;set;}
    [Required]
    public string JobType {get;set;}
    [Required]

    public decimal MinimumSalary {get;set;}
    [Required]
    public decimal MaxmumSalary {get;set;}
    [Required]
    public DateTime PostedDate{get;set;}
    [Required]
    public DateTime? DeadLineDate {get;set;}
    [Required]
    public bool isActive {get;set;}
    public User PostBy {get;set;}
    public int PostedById {get;set;}
}