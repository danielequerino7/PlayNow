import 'package:play_now/domain/reserva.dart';

class Usuario {
  String nome;
  String email;
  String senha;
  String telefone;
  bool isAdmin = false;

  Usuario({
    required this.nome,
    required this.email,
    required this.senha,
    required this.telefone,
    required this.isAdmin
  });

  void fazerReserva(Reserva reserva){

  }

  void cancelarReserva(Reserva reserva){

  }
}