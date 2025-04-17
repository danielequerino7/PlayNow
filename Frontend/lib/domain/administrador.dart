import 'package:play_now/domain/associado.dart';
import 'package:play_now/domain/quadra.dart';
import 'package:play_now/domain/reserva.dart';
import 'package:play_now/domain/usuario.dart';

class Administrador extends Usuario{
  int idAdministrador;

  Administrador({
    required this.idAdministrador,
  }) : super(nome: '', email: '', senha: '', telefone: '', isAdmin: false);

  void cadastrarQuadra(Quadra quadra) {

  }

  void editarQuadra(Quadra quadra) {

  }

  void cadastrarAssociado(Associado associado){

  }

  void cancelarReservaAssociado(Reserva reserva, int idAssociado){

  }

  void cadastrarAdministrador(Administrador administrador) {

  }

}