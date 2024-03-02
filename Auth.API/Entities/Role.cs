﻿namespace Auth.API.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Permission> Permissions { get; set; }
    }
}
