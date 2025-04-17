import 'dart:ffi';

import 'package:play_now/domain/quadra.dart';
import 'package:play_now/domain/usuario.dart';

class Reserva {
  DateTime horario;
  int idReserva;
  Quadra quadra;
  Usuario usuario;
  List<String> listaPessoas;

  Reserva({
    required this.horario,
    required this.idReserva,
    required this.quadra,
    required this.usuario,
    required this.listaPessoas
  });

  void verificarQuadra(Quadra quadra) {

  }

  void verificarQuantidade(Quadra quadra) {

  }

  void verificarUsuario(Usuario usuario) {

  }

}