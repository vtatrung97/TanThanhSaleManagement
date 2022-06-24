using Delta.SaleProject.Auditing;
using Delta.SaleProject.Test.Base;
using Shouldly;
using Xunit;

namespace Delta.SaleProject.Tests.Auditing
{
    // ReSharper disable once InconsistentNaming
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
            var controllerName = _namespaceStripper.StripNameSpace("Delta.SaleProject.Web.Controllers.HomeController");
            controllerName.ShouldBe("HomeController");
        }

        [Theory]
        [InlineData("Delta.SaleProject.Auditing.GenericEntityService`1[[Delta.SaleProject.Storage.BinaryObject, Delta.SaleProject.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null]]", "GenericEntityService<BinaryObject>")]
        [InlineData("CompanyName.ProductName.Services.Base.EntityService`6[[CompanyName.ProductName.Entity.Book, CompanyName.ProductName.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[CompanyName.ProductName.Services.Dto.Book.CreateInput, N...", "EntityService<Book, CreateInput>")]
        [InlineData("Delta.SaleProject.Auditing.XEntityService`1[Delta.SaleProject.Auditing.AService`5[[Delta.SaleProject.Storage.BinaryObject, Delta.SaleProject.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],[Delta.SaleProject.Storage.TestObject, Delta.SaleProject.Core, Version=1.10.1.0, Culture=neutral, PublicKeyToken=null],]]", "XEntityService<AService<BinaryObject, TestObject>>")]
        public void Should_Stripe_Generic_Namespace(string serviceName, string result)
        {
            var genericServiceName = _namespaceStripper.StripNameSpace(serviceName);
            genericServiceName.ShouldBe(result);
        }
    }
}
