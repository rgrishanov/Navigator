Prova prática - Provider IT
Desenvolvedor: Roman Grishanov

Solução do Problema 3


Problema 3
Assuma um plano cartesiano de coordenadas X x Y.
Assumindo uma posição original (x,y), a aplicação irá receber vetores de coordenadas na
seguinte forma:
[Direção, Intensidade], sendo que Direção pode ser N,S,L,O (Norte, Sul, Leste e Oeste) e
intensidade é um inteiro.
Ex:
Digamos que nosso ponto atual é (1,1) e recebe um vetor [N,10], ele precisa parar na posição
(1,11). Se após isso a aplicação receber o vetor [L,5], a posição atual deve ser (6,11).
Casos de Teste
1) Assuma como ponto de partida (8,12). Após receber os vetores abaixo, a aplicação
deve exibir a posição (34,10).
a) [N,23] (8,35)
b) [O,7] (1,35)
c) [S,40] (1,-5)
d) [L,33] (34,-5)
e) [N,15] (34,10)
2) Assuma como ponto de partida (-10,0). Após receber os vetores abaixo, a aplicação
deve exibir a posição (-14,7).
a) [L,14] (4,0)
b) [N,27] (4,27)
c) [O,33] (-29,27)
d) [S,20] (-29,7)
e) [L,15] (-14,7)
