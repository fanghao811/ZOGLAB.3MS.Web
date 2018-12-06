using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZOGLAB.S_3MS.Auditing;
using Shouldly;
using Xunit;

namespace ZOGLAB.S_3MS.Tests.Auditing
{
    public class NamespaceStripper_Tests: AppTestBase
    {
        private readonly INamespaceStripper _namespaceStripper;

        public NamespaceStripper_Tests()
        {
            _namespaceStripper = Resolve<INamespaceStripper>();
        }

        [Fact]
        public void Should_Stripe_Namespace()
        {
            var controllerName = _namespaceStripper.StripNameSpace("ZOGLAB.S_3MS.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("ZOGLAB.S_3MS.Auditing.GenericEntityService`1[[ZOGLAB.S_3MS.Storage.BinaryObject, ZOGLAB.S_3MS.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("ZOGLAB.S_3MS.Auditing.XEntityService`1[ZOGLAB.S_3MS.Auditing.AService`5[[ZOGLAB.S_3MS.Storage.BinaryObject, ZOGLAB.S_3MS.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[ZOGLAB.S_3MS.Storage.TestObject, ZOGLAB.S_3MS.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}
