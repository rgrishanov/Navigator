using Moq;
using Navigator.Presenter;
using Navigator.View;
using System;
using Xunit;

namespace Navigator.Tests {
    public class PresenterTests {
        private readonly INavigatorView mockNavigatorView;
        private readonly NavigatorPresenter presenter;


        public PresenterTests() {
            mockNavigatorView = Mock.Of<INavigatorView>();

            presenter = new NavigatorPresenter(mockNavigatorView);
        }

        [Fact]
        public void Presenter_NavigatorFull_Case1() {
            var mockView = Mock.Get(mockNavigatorView);
            mockView.Setup(view => view.OriginPoint).Returns("(8,12)");
            mockView.Setup(view => view.Movements).Returns("[N,23];[O,7];[S,40];[L,33];[N,15]");

            presenter.Navigate();

            Assert.True(mockNavigatorView.ResultPoint == "(34,10)");
        }

        [Fact]
        public void Presenter_NavigatorFull_Case2() {
            var mockView = Mock.Get(mockNavigatorView);
            mockView.Setup(view => view.OriginPoint).Returns("(-10,0)");
            mockView.Setup(view => view.Movements).Returns("[L,14];[N,27];[O,33];[S,20];[L,15]");

            presenter.Navigate();

            Assert.True(mockNavigatorView.ResultPoint == "(-14,7)");
        }

        [Fact]
        public void Presenter_NavigatorSteps_Case1() {
            var mockView = Mock.Get(mockNavigatorView);

            mockView.Setup(view => view.OriginPoint).Returns("(8,12)");

            mockView.Setup(view => view.Movements).Returns("[N,23]");
            presenter.Navigate();
            Assert.True(mockNavigatorView.ResultPoint == "(8,35)");

            mockView.Setup(view => view.OriginPoint).Returns("(8,35)");
            mockView.Setup(view => view.Movements).Returns("[O,7]");
            presenter.Navigate();
            Assert.True(mockNavigatorView.ResultPoint == "(1,35)");

            mockView.Setup(view => view.OriginPoint).Returns("(1,35)");
            mockView.Setup(view => view.Movements).Returns("[S,40]");
            presenter.Navigate();
            Assert.True(mockNavigatorView.ResultPoint == "(1,-5)");

            mockView.Setup(view => view.OriginPoint).Returns("(1,-5)");
            mockView.Setup(view => view.Movements).Returns("[L,33]");
            presenter.Navigate();
            Assert.True(mockNavigatorView.ResultPoint == "(34,-5)");

            mockView.Setup(view => view.OriginPoint).Returns("(34,-5)");
            mockView.Setup(view => view.Movements).Returns("[N,15]");
            presenter.Navigate();
            Assert.True(mockNavigatorView.ResultPoint == "(34,10)");
        }

        [Fact]
        public void Presenter_NavigatorSteps_Case2() {
            var mockView = Mock.Get(mockNavigatorView);

            mockView.Setup(view => view.OriginPoint).Returns("(-10,0)");

            mockView.Setup(view => view.Movements).Returns("[L,14]");
            presenter.Navigate();
            Assert.True(mockNavigatorView.ResultPoint == "(4,0)");

            mockView.Setup(view => view.OriginPoint).Returns("(4,0)");
            mockView.Setup(view => view.Movements).Returns("[N,27]");
            presenter.Navigate();
            Assert.True(mockNavigatorView.ResultPoint == "(4,27)");

            mockView.Setup(view => view.OriginPoint).Returns("(4,27)");
            mockView.Setup(view => view.Movements).Returns("[O,33]");
            presenter.Navigate();
            Assert.True(mockNavigatorView.ResultPoint == "(-29,27)");

            mockView.Setup(view => view.OriginPoint).Returns("(-29,27)");
            mockView.Setup(view => view.Movements).Returns("[S,20]");
            presenter.Navigate();
            Assert.True(mockNavigatorView.ResultPoint == "(-29,7)");

            mockView.Setup(view => view.OriginPoint).Returns("(-29,7)");
            mockView.Setup(view => view.Movements).Returns("[L,15]");
            presenter.Navigate();
            Assert.True(mockNavigatorView.ResultPoint == "(-14,7)");
        }
    }
}
