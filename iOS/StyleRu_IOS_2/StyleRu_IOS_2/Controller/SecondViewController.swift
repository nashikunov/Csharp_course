//
//  SecondViewController.swift
//  StyleRu_IOS_2
//
//  Created by Sergey on 2/27/18.
//  Copyright © 2018 Бизнес в стиле .RU. All rights reserved.
//

import UIKit

class SecondViewController: UIViewController {

    @IBOutlet weak var imageLabel: UILabel!
    var textForImageLabel: String?
    
    override func viewDidLoad() {
        super.viewDidLoad()
        print("View did load => all outlets set")
        imageLabel.text = textForImageLabel
    }
}
