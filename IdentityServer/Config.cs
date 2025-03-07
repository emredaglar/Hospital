// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            new ApiResource("ResourceEmployee"){Scopes={"EmployeeReadPermisson","EmployeeCreatePermisson"}},
            new ApiResource("ResouseEmployee2"){Scopes={"EmployeeFullPersmisson"}},
            new ApiResource("PatientResource"){Scopes={"PatientFullPermisson"}},
             new ApiResource("PrescriptionResource"){Scopes={"PrescriptionFullPermisson"}},
             new ApiResource("AppointmentResource"){Scopes={"AppointmentFullPermisson"}},
             new ApiResource("ReviewResource"){Scopes={"ReviewFullPermisson"}},
             new ApiResource("PaymentResource"){Scopes={"PaymentFullPermisson"}},
             new ApiResource("MessageResource"){Scopes={"MessageFullPermisson"}},
             new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };
        public static IEnumerable<IdentityResource> IdentityResources => new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email()
        };
        public static IEnumerable<ApiScope> ApiScopes => new ApiScope[]
        {
            new ApiScope("EmployeeReadPermisson","Read Employee Authority For Employee Operations"),
            new ApiScope("EmployeeCreatePermisson","Create Employee Authority For Employee Operations"),
            new ApiScope("PatientFullPermisson","Full Authority For Employee Operations"),
            new ApiScope("PrescriptionFullPermisson","Full Authority For Employee Operations"),
            new ApiScope("AppointmentFullPermisson","Full Authority For Employee Operations"),
            new ApiScope("ReviewFullPermisson","Full Authority For Employee Operations"),
            new ApiScope("PaymentFullPermisson","Full Authority For Employee Operations"),
            new ApiScope("MessageFullPermisson","Full Authority For Employee Operations"),
        };





    }
}