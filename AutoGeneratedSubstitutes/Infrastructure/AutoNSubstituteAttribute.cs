using AutoFixture;
using AutoFixture.Xunit2;

namespace AutoGeneratedSubstitutes
{
      class AutoNSubstituteAttribute : AutoDataAttribute
    {
        public AutoNSubstituteAttribute() 
            : base(()=>new Fixture()
                .Customize(new AutoPopulatedNSubstitutePropertiesCustomization()))
        {

        }
    }
}