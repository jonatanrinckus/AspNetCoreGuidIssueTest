using System;

namespace AspNetCoreGuidIssueTest.Models
{
    public class Test
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid AnotherGuidId { get; set; }
    }
}