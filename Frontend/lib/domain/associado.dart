import 'package:play_now/domain/usuario.dart';

class Associado extends Usuario{
  int idAssociado;

  Associado({
    required this.idAssociado,
  }) : super(nome: '', email: '', senha: '', telefone: '', isAdmin: false);

}