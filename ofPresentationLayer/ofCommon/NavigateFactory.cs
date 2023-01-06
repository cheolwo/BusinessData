using BusinessData;
using BusinessData.ofDataAccessLayer.ofCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessData.ofPresentationLayer.ofCommon
{
    public static class RoleView
    {
        public const string Create = "create";
        public const string Delete = "delete";
        public const string Update = "update";
        public const string Get = "get";
        public const string Register = "register";
    }
    public class NavigateFactory<T> where T : Entity, new()
    {
        public string NameofT { get; set; }
        private T t = new();
        public NavigateFactory()
        {
            NameofT = t.GetRelationCodeToLower(typeof(T));
        }
        public string CreateRoleNavigationString(string RoleView)
        {
            return $"{RoleView}/user/role";
        }
        public string CreateUserNavigationString(string Id, string RoleView)
        {
             return $"/{RoleView}/user/nameof(T)/{Id}";
        }
        public  string CreateUserNaviationString(string RoleView) 
        {
            return $"{RoleView}/user/{NameofT}";
        }
    }
}
