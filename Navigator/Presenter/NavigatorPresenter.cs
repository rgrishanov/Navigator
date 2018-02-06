using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator.Presenter {

	public class NavigatorPresenter {
		private View.INavigatorView _view;

		public NavigatorPresenter(View.INavigatorView view) {

			_view = view;
			view.Presenter = this;
		}

		public void Navigate() {

			Model.NavigationProcessor processor = new Model.NavigationProcessor();
			try {
                string resultPoint = processor.CalculatePosition(this.ParseOriginPoint(), this.ParseMovements()).ToString().Replace(" ", string.Empty);

				_view.ResultPoint = resultPoint;
				if (_view.AutoUpdateOriginPoint) {
					_view.OriginPoint = resultPoint;
				}
			}
			catch (Exception ex) {
				_view.ShowErrorMessage(ex.Message);
			}
		}

		private Tuple<int, int> ParseOriginPoint() {
			int x = 0;
			int y = 0;
			string cleanCoordinate = _view.OriginPoint.Trim().Replace("(", string.Empty).Replace(")", string.Empty);

			if (cleanCoordinate.Split(',').Count() != 2 ||
				int.TryParse(cleanCoordinate.Split(',')[0], out x) == false ||
				int.TryParse(cleanCoordinate.Split(',')[1], out y) == false) {
					throw new Exception("Formato inválido do ponto de origem. Ponto de origem deve ter somente 2 coordenadas núméricas inteiras, separadas por vírgula. Exemplo: 3,-5");
			}
			return new Tuple<int, int>(x, y);
		}

		private List<Tuple<char, int>> ParseMovements() {
			List<Tuple<char, int>> movementList = new List<Tuple<char, int>>();
			char a = 'x';
			int n = 0;
			foreach (string movement in _view.Movements.Trim().Replace("[", string.Empty).Replace("]", string.Empty).Split(';')) {
				if (movement.Trim().Split(',').Count() != 2 ||
				char.TryParse(movement.Trim().Split(',')[0], out a) == false ||
				int.TryParse(movement.Trim().Split(',')[1], out n) == false) {
					throw new Exception("Formato dos movimentos inválido. Movimentos devem estar no formato [N,23];[O,7];[S,40];[L,33].");
				}
				movementList.Add(new Tuple<char, int>(a, n));
			}

			return movementList;
		}
	}
}
