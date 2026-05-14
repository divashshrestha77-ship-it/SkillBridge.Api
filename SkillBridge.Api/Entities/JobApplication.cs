using System.ComponentModel.DataAnnotations;
using SkillBridge.Api.Entities;

namespace SkillBridge.api.Entities
{
    public class JobApplicaitions
{
    [Required,Key]
    public int Id {get;set;}
    public Job AppliedJob {get;set;}
    public int AppliedjobId {get;set;}
    public User AppliedBy {get;set;}
    public int AppliedById {get;set;}
    [Required]
    public DateTime ApplicationDate{get;set;}
    [Required]
    public String Status{get;set;}
    public bool isActive {get;set;}
    [Required]
    public String CoverLetter {get;set;}
    [Required]
    public String ResumePath {get;set;}



}
}