using System;
using Xunit;
using SUT = BrokerageLib;  

namespace BrokerageLib.XUnit.Tests.PaymentDate
{
    public class CalculateFuturePaymentDate_Should
    {
        [Fact]
        public void ReturnDate30DaysInFuture_WhenProposedDateFallsOnWeekday()
        {
            // arrange
            var pd = new SUT.PaymentSystem.PaymentDate();
            DateTime sampleDate = DateTime.Parse("8/7/2011");

            // act
            var resultDateWhichShouldBeMonday = pd.CalculateFuturePaymentDate(sampleDate);

            Assert.Equal(expected: DayOfWeek.Monday,
                    actual: resultDateWhichShouldBeMonday.DayOfWeek);
        }

        [Fact]
        public void ReturnMonday_WhenProposedDateFallsOnSunday()
        {
            // arrange
            var pd = new SUT.PaymentSystem.PaymentDate();

            DateTime sampleDate = DateTime.Parse("8/7/2011");

            // act
            var resultDateWhichShouldBeMonday = pd.CalculateFuturePaymentDate(sampleDate);

            // assert

            Assert.Equal(expected: DayOfWeek.Monday,
                actual: resultDateWhichShouldBeMonday.DayOfWeek);
        }

        [Fact]
        public void ReturnMonday_WhenProposedDateFallsOnSaturday()
        {
            // arrange
            var pd = new SUT.PaymentSystem.PaymentDate();

            DateTime sampleDate = DateTime.Parse("7/7/2011");

            // act
            var resultDateWhichShouldBeMonday = pd.CalculateFuturePaymentDate(sampleDate);

            // assert

            Assert.Equal(expected: DayOfWeek.Monday,
                actual: resultDateWhichShouldBeMonday.DayOfWeek);
        }
    }
}