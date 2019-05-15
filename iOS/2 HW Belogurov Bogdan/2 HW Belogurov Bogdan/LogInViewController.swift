//
//  LogInViewController.swift
//  2 HW Belogurov Bogdan
//
//  Created by Bogdan Belogurov on 01.03.2018.
//  Copyright © 2018 Bogdan Belogurov. All rights reserved.
//

import UIKit

class LogInViewController: UIViewController {

    let login: String! = "Bogdan"
    let password: String! = "314159"
    @IBOutlet weak var logInTextField: UITextField!
    @IBOutlet weak var passwordTextField: UITextField!
    @IBOutlet weak var logoImage: UIImageView!
    
    
    @IBAction func buttonLogInPressed(_ sender: Any) {
        if logInTextField.text == login && passwordTextField.text == password {
            performSegue(withIdentifier: "login", sender: sender)
        } else {
            let alertController = UIAlertController(title: "Incorrect username or password", message: nil, preferredStyle: .alert)
            
            let cancelAction = UIAlertAction(title: "Okey", style: .destructive, handler: nil)
            alertController.addAction(cancelAction)
            self.present(alertController, animated: true, completion: nil)
        }
        
    }

    
    override func viewDidAppear(_ animated: Bool) {
        super.viewDidAppear(animated)
        
            UIView.animate(withDuration: 0.9, delay: 0.4, usingSpringWithDamping: 0.5, initialSpringVelocity: 0, animations: {
                self.logoImage?.transform = CGAffineTransform(scaleX: 1, y: 1)
            }, completion: nil)
            
        }
    
//    override func prepare(for segue: UIStoryboardSegue, sender: Any?) {
//        if segue.identifier == "Show NewVC"{
//            let destinationVC = segue.destination as! NewViewController
//            destinationVC.bufferText = "This is text"
//        }
//    }
    override func viewDidLoad() {
        super.viewDidLoad()

        logoImage.transform = CGAffineTransform(scaleX: 0, y: 0)
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
    }
    
    override func touchesBegan(_ touches: Set<UITouch>, with event: UIEvent?) {
        self.view.endEditing(true)
    }
    


}
