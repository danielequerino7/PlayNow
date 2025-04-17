import 'package:play_now/domain/categoria.dart';

class Quadra {
  Categoria categoria;
  int idQuadra;
  int numero;
  int maximoPessoas;

  Quadra({
    required this.categoria,
    required this.idQuadra,
    required this.numero,
    required this.maximoPessoas,
  });

}