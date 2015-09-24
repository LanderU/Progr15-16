//
//  ViewController.swift
//  HolaMundo
//
//  Created by Lander on 24/9/15.
//  Copyright © 2015 Lander. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }


    @IBAction func botonPulsado(sender: UIButton) {
        
        etiqueta.text = "Hola Mundo!!!"
        
    }
    
    @IBOutlet weak var etiqueta: UILabel!
    
}

