import 'package:flutter/material.dart';
import 'package:flutter_application_8/test.dart';
import 'test.dart';

class PageState extends StatefulWidget{
  @override
  MyPageState createState() => MyPageState();
}

class MyPageState extends State<PageState> {
  TextEditingController num1 = new TextEditingController();
  TextEditingController num2 = new TextEditingController();
  int resultado = 0;
  
  double valor = 0;
  String simbolo = "";

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
          appBar: AppBar(title: const Text('Widgets')),
          body: Column(
            children: [
              TextField(controller: num1,
                decoration: const InputDecoration(labelText: 'Numero 1'),
              ),
              TextField(controller: num2,
                decoration: const InputDecoration(labelText: 'Numero 2'),
              ),
              Row(
                children: [
                  Expanded(
                      child: ElevatedButton(
                          onPressed: (){ setState(() {
                            simbolo = "+";
                          });}, child: const Text("+"))),
                  Expanded(
                      child: ElevatedButton(
                          onPressed: () {setState(() {
                            simbolo = "-";
                          });
                          }, child: const Text("-"))),
                  Expanded(
                      child: ElevatedButton(
                          onPressed: () {setState(() {
                            simbolo = "*";
                          });}, child: const Text("*"))),
                  Expanded(
                      child: ElevatedButton(
                          onPressed: () {
                              simbolo = "/";
                            }, child: const Text("/")))
                ],
              ),
              Text(valor.toString()),
              Row(children: [
                Expanded(
                child:
                    ElevatedButton(onPressed: () {
                      if (simbolo == "+"){
                      setState(() {
                            valor = double.parse(num1.text) + double.parse(num2.text);
                          });
                        }
                    }, child: const Text("Calcular")))
              ]),
              Row(children: [
                Expanded(child: 
                  ElevatedButton(onPressed: () {},child: const Text("Limpar"),
                ))
              ])
            ],
          )));
  }
}


void main() {
  runApp(
    MaterialApp(
    home: PageState(),
  ));
}