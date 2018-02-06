using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigator.Model {
	public class NavigationProcessor {
		public NavigationProcessor() {

		}

		public Tuple<int, int> CalculatePosition(Tuple<int, int> initialPosition, List<Tuple<char, int>> movements) {
			int resultX = initialPosition.Item1;
			int resultY = initialPosition.Item2;

			Tuple<int, int> finalPosition = initialPosition;
			foreach (Tuple<char, int> movement in movements) {
				switch (movement.Item1) {
					case 'N':
					case 'n':
						resultY += movement.Item2;
						break;
					case 'S':
					case 's':
						resultY -= movement.Item2;
						break;
					case 'L':
					case 'l':
						resultX += movement.Item2;
						break;
					case 'O':
					case 'o':
						resultX -= movement.Item2;
						break;
					default:
						throw new Exception("Direção do movimento inválida. As direções somente podem ser: N, S, L, O (Norte, Sul, Leeste e Oeste).");
				}
			}

			return new Tuple<int, int>(resultX, resultY);
		}
	}
}
