﻿using UnityEngine;
	
public interface IEnemyModel {
	
	//constructor	
	void Start ();


	//_________________________________________________
	//MODEL LAYER methods:
	
	/*
	Move():
		- Making character walk to desired position
		- Receives keyboard/gamepad axis input value
		- Translates input value into character desired position 
	*/
	void Move(float inputX, float inputZ);
	
	
	/*
	Run():
		- Making character run to desired position
		- Receives keyboard/gamepad axis input value
		- Translates input value into character desired position 
	*/
	void Run(float inputX, float inputZ);
	
	
	/*
	Look():
		- Make character look (rotate) in certain direction
		- Receive mouse movement
		- OR receive gamepad's right stick movement
		- Translate it to characters rotation
	*/
	void Look(float inputX, float inputZ);
	
	void Look(Vector3 mousePosition);
	
	
	/*
	Shoot():
		- Force character to shoot his gun
		- Receive data shootButton up or down value
		- OR receive gamepad's right trigger force
		- Force gun to shoot missle
	*/
	void Shoot(bool isTriggerPressed);
	
	
	/*
	Reload():
		- Make character reload his currently equipped gun
		- Receive no data
		- Reload active gun
	*/
	void Reload();
	
	
	/*
	SwitchGun():
		- Quickly switch equipped gun
		- Receive switchForwardButton / switchBackwardButton
		- Switch gun to next/previous gun in queue
	*/
	void SwitchGun();  //?
	
	
}