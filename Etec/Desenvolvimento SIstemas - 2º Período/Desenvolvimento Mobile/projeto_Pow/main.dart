import 'dart:math';

import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
TextEditingController txtBase = TextEditingController();
TextEditingController txtExpo = TextEditingController();
TextEditingController txtResult = TextEditingController();
void main() {
  runApp(MaterialApp(
      title: 'Calcular Nota',
      home: Scaffold(
          appBar: AppBar(title: const Text('Texto da barra de título')),
          body: 
            Column(crossAxisAlignment: CrossAxisAlignment.stretch, children: [
              TextField(controller: txtBase,
                   decoration: const InputDecoration(labelText: 'Informe a base'),
                   
              ),
              TextField(controller: txtExpo,
                   decoration: const InputDecoration(labelText: 'Informe o expoente'),
            ),  
                ElevatedButton(child: const Text('Calcular'), onPressed: () => calcular()), 
                ElevatedButton(child: const Text('Limpar'), onPressed: ()=> clean()), 
              TextField(controller: txtResult ),
                ElevatedButton(child: const Text('Fechar'), onPressed: () =>fecharapp()),
                  
            ],)
            
      )
  ));
}
calcular(){
  double base = double.parse(txtBase.text);
  double expo = double.parse(txtExpo.text);
  num resultado = pow(base, expo);

  txtResult.text = resultado.toString();
}

fecharapp(){
  SystemNavigator.pop();
}

clean(){
  txtBase.clear();
  txtExpo.clear();
  txtResult.clear();
}