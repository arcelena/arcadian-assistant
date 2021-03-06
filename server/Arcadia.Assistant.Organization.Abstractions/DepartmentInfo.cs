﻿namespace Arcadia.Assistant.Organization.Abstractions
{
    public class DepartmentInfo
    {
        public string DepartmentId { get; }

        public string Abbreviation { get; }

        public string Name { get; }

        public string ParentDepartmentId { get; }

        public string ChiefId { get; set; }

        public DepartmentInfo(string departmentId, string name, string abbreviation, string parentDepartmentId = null)
        {
            this.DepartmentId = departmentId;
            this.Name = name;
            this.Abbreviation = abbreviation;
            this.ParentDepartmentId = parentDepartmentId;
        }
    }
}