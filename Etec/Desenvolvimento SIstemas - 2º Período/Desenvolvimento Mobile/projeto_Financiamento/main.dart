import 'dart:math';

import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
TextEditingController txtValorFinanciado = TextEditingController();
TextEditingController txtPorcentagemEntrada = TextEditingController();
TextEditingController txtNumeroParcelas = TextEditingController();
TextEditingController txtJurosAoMes = TextEditingController();
TextEditingController txtValorEntrada = TextEditingController();
TextEditingController txtValorParcelado = TextEditingController();
TextEditingController txtTotal = TextEditingController();
void main() {
  runApp(MaterialApp(
      title: 'Calcular Nota',
      home: Scaffold(
          appBar: AppBar(title: const Text('Texto da barra de título')),
          body: 
            Column(crossAxisAlignment: CrossAxisAlignment.stretch, children: [
              TextField(controller: txtValorFinanciado,
                decoration: const InputDecoration(labelText: "Valor Financiado")),
              TextField(controller: txtPorcentagemEntrada,
                decoration: const InputDecoration(labelText: "% de Entrada")),
              TextField(controller: txtNumeroParcelas,
                decoration: const InputDecoration(labelText: "Número de Parcelas")),
              TextField(controller: txtJurosAoMes,
                decoration: const InputDecoration(labelText: "Juros ao Mês")),
              ElevatedButton(onPressed: () => calcular(), child: const Text("Calcular")),
              TextField(controller: txtValorEntrada),
              TextField(controller: txtValorParcelado),
              TextField(controller: txtTotal),
              ElevatedButton(onPressed: () => clean(), child: const Text("Limpar")),
              ElevatedButton(onPressed: () => fecharapp(), child: const Text("Sair")),
            ],)
            
      )
  ));
}
calcular(){
  int numParcelas = int.parse(txtNumeroParcelas.text);
  int jurosMes = int.parse(txtJurosAoMes.text);
  int valorFinanciado = int.parse(txtValorFinanciado.text);
  int valorEntradaPorcentagem = int.parse(txtPorcentagemEntrada.text);
  double valorEntrada = valorFinanciado * (valorEntradaPorcentagem / 100);
  double valorRestante = valorFinanciado - valorEntrada;
  txtValorEntrada.text = valorEntrada.toString();
  

  for(int i = 0; i < numParcelas; i++){
    valorRestante += (valorRestante * (jurosMes / 100));
  }
  
  txtValorParcelado.text = valorRestante.toString();
  
  txtTotal.text = (valorRestante + valorEntrada).toString();
}

fecharapp(){
  SystemNavigator.pop();
}

clean(){
  txtJurosAoMes.clear();
  txtNumeroParcelas.clear();
  txtPorcentagemEntrada.clear();
  txtTotal.clear();
  txtValorEntrada.clear();
  txtValorFinanciado.clear();
  txtValorParcelado.clear();
}