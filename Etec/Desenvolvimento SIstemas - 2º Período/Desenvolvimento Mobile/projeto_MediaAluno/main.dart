import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
TextEditingController txtNota1 = TextEditingController();
TextEditingController txtNota2 = TextEditingController();
TextEditingController txtNota3 = TextEditingController();
TextEditingController txtMed = TextEditingController();
TextEditingController txtResult = TextEditingController();

void main() {
  runApp(MaterialApp(
      title: 'Calcular Nota',
      home: Scaffold(
          appBar: AppBar(title: const Text('Texto da barra de título')),
          body: 
            Column(crossAxisAlignment: CrossAxisAlignment.stretch, children: [
              TextField(controller: txtNota1,
                decoration: const InputDecoration(labelText:'Nota 1'),
              ),
            TextField(controller: txtNota2,
                decoration: const InputDecoration(labelText:'Nota 2'),
              ),
              TextField(controller: txtNota3,
                decoration: const InputDecoration(labelText:'Nota 3'),
              ),
              ElevatedButton(child: const Text('Média'), onPressed:(){calcularmedia();}),
              ElevatedButton(onPressed:(){limparcampos();}, child: const Text('Limpar')),
              TextField(controller: txtMed),
              TextField(controller: txtResult),
              ElevatedButton(onPressed:(){fecharapp();}, child: const Text('Fechar')),
            ],)
      )
  ));
}


calcularmedia(){
 double media = (double.parse(txtNota1.text) + double.parse(txtNota2.text) + double.parse(txtNota3.text)) /3;
 txtMed.text = media.toString();
 if(media >= 7){
  txtResult.text = "APROVADO";
 }
 else{
  txtResult.text = "REPROVADO";
 }
}

limparcampos(){
  txtNota1.clear();
  txtNota2.clear();
  txtNota3.clear();
  txtMed.clear();
  txtResult.clear();

}

fecharapp(){
  SystemNavigator.pop();
}