//
//  FirstViewController.swift
//  StyleRu_IOS_2
//
//  Created by Sergey on 2/27/18.
//  Copyright © 2018 Бизнес в стиле .RU. All rights reserved.
//

import UIKit

class FirstViewController: UIViewController {

    @IBOutlet weak var sampleLabel: UILabel!
    
    @IBAction func segueButtonPressed(_ sender: Any, forEvent event: UIEvent) {
        performSegue(withIdentifier: "Show Second View Controller", sender: sender)
    }
    
    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
        if segue.identifier == "Show Second View Controller"{
            let destinationVC = segue.destination as! SecondViewController
            print("Second View Controller class created")
            destinationVC.textForImageLabel = "University"
        }
    }
    
}
