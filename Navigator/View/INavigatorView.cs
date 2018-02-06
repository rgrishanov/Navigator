using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator.View {
	public interface INavigatorView {
		Presenter.NavigatorPresenter Presenter { set; }

		string OriginPoint { get; set; }
		string Movements { get; set; }
		string ResultPoint { get; set; }

		bool AutoUpdateOriginPoint { get; }

		void ShowErrorMessage(string errorMessage);
	}
}
