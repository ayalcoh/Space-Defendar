{
    "name": "PlayerControll",
    "maps": [
        {
            "name": "Ship Control",
            "id": "79c85f5c-5dce-4918-890f-c4e57ed544dc",
            "actions": [
                {
                    "name": "Thrust",
                    "type": "PassThrough",
                    "id": "4e905588-a388-4f96-8e69-f76ad16e29d9",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Strafe",
                    "type": "PassThrough",
                    "id": "10067040-b660-4fbe-9167-7cafdb00e92e",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "downUp",
                    "type": "PassThrough",
                    "id": "f8401d9c-05f6-40fb-a144-7fbbd5bd6815",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Roll",
                    "type": "PassThrough",
                    "id": "c318ec91-4543-4c0c-a80e-c8fb035eb23c",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "PitchYaw",
                    "type": "PassThrough",
                    "id": "14e8e0de-f46f-4e3e-86dc-aa2eb682021f",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Boost",
                    "type": "PassThrough",
                    "id": "90317512-b3f6-486c-bbd3-547b4e7eb350",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "Press",
                    "initialStateCheck": false
                },
                {
                    "name": "Interact",
                    "type": "PassThrough",
                    "id": "cd9bbfad-b760-4afe-b182-71e63727fa1b",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "Press",
                    "initialStateCheck": false
                },
                {
                    "name": "SwapCam",
                    "type": "PassThrough",
                    "id": "405ecf99-070f-4944-9837-c15ed58daa9b",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "Press",
                    "initialStateCheck": false
                },
                {
                    "name": "Fire Laser",
                    "type": "PassThrough",
                    "id": "cf10001c-a322-480d-9572-2e0a3b04837c",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "Press",
                    "initialStateCheck": false
                },
                {
                    "name": "Fire Missle",
                    "type": "PassThrough",
                    "id": "fe8d64b8-103f-41d4-aff3-ab8672ea5b9b",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "Press",
                    "initialStateCheck": false
                }
            ],
            "bindings": [
                {
                    "name": "ThrustKB",
                    "id": "73bbc337-0a01-408b-ace0-cf7f9cc86479",
                    "path": "1DAxis",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Thrust",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "negative",
                    "id": "4e4e3770-ed2a-4c20-91d2-40aa360c1ae3",
                    "path": "<Keyboard>/s",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Thrust",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "positive",
                    "id": "c1327a31-643f-489d-850d-edd88131378f",
                    "path": "<Keyboard>/w",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Thrust",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "ThrustController",
                    "id": "384ee7d6-3b85-4249-ad99-9db95980c3db",
                    "path": "1DAxis",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Thrust",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "negative",
                    "id": "b71a3b81-2b62-43d8-bb91-d8016bade2c2",
                    "path": "<Gamepad>/leftStick/down",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Thrust",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "positive",
                    "id": "b452f52b-15c7-47a8-ab15-62bf610accc8",
                    "path": "<Gamepad>/leftStick/up",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Thrust",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "StrafeKB",
                    "id": "4883df01-d9f0-4b19-89d7-3577a2b6c53d",
                    "path": "1DAxis",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Strafe",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "negative",
                    "id": "55174b7c-2f32-49da-bce8-63de21dc6e3a",
                    "path": "<Keyboard>/a",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Strafe",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "positive",
                    "id": "d89c9c71-b464-4b27-9cc1-578abe47dfc5",
                    "path": "<Keyboard>/d",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Strafe",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "StrafeController",
                    "id": "83665e1d-7b22-40b6-a791-299a7b7952ef",
                    "path": "1DAxis",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Strafe",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "negative",
                    "id": "89123f09-d2da-4a8d-9549-f4ffd4b8faf3",
                    "path": "<Gamepad>/leftStick/left",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Strafe",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "positive",
                    "id": "8c6276e7-8876-46b2-a67c-730db678de18",
                    "path": "<Gamepad>/leftStick/right",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Strafe",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "downUpKB",
                    "id": "2bdc9e27-bd42-4995-9840-dba1dfcb0f07",
                    "path": "1DAxis",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "downUp",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "negative",
                    "id": "7d7b2438-80dc-43c9-aa41-9d86960896fa",
                    "path": "<Keyboard>/leftCtrl",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "downUp",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "positive",
                    "id": "2d29f8d6-3f2e-4eed-8825-2e3f34ece4ab",
                    "path": "<Keyboard>/space",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "downUp",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "downUpController",
                    "id": "d6219585-63f3-4904-b56c-a73cb4a01ccf",
                    "path": "1DAxis",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "downUp",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "negative",
                    "id": "e2a26e9c-8448-4983-93b0-224394732219",
                    "path": "<Gamepad>/leftShoulder",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "downUp",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "positive",
                    "id": "a5f46f15-a835-4777-975e-c1d39e54c724",
                    "path": "<Gamepad>/rightShoulder",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "downUp",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "rollKB",
                    "id": "975bd05e-730c-4c51-ab69-aa018980b7b0",
                    "path": "1DAxis",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Roll",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "negative",
                    "id": "57772983-a606-4634-8fc3-ebd416d21124",
                    "path": "<Keyboard>/q",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Roll",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "positive",
                    "id": "e2b2adaa-e0de-4cc1-be29-93b1f735981c",
                    "path": "<Keyboard>/e",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Roll",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "rollController",
                    "id": "ae713325-6ef4-4bde-835b-dab49b500ba1",
                    "path": "1DAxis",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Roll",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "negative",
                    "id": "82de5da9-832b-4174-988e-9003be80624b",
                    "path": "<Gamepad>/leftTrigger",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Roll",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "positive",
                    "id": "e50298f0-6d21-4706-a355-2a74e7621313",
                    "path": "<Gamepad>/rightTrigger",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Roll",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "",
                    "id": "97fec8f6-ae36-435d-81c4-74dcfe882493",
                    "path": "<Gamepad>/rightStick",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "PitchYaw",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "dda71222-bc86-40d1-9f14-7d258215a5f4",
                    "path": "<Mouse>/delta",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "PitchYaw",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "58131415-6762-493e-87b7-b683f1ec1b89",
                    "path": "<Keyboard>/leftShift",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Boost",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "62d9ab53-7133-48a1-9a9c-e46e9246902d",
                    "path": "<Gamepad>/buttonEast",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Boost",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "77a01819-c7f5-4789-9fa7-8189cc28977d",
                    "path": "<Keyboard>/f",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Interact",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "bace3eec-df39-49d2-93ea-bac8a6b64ed5",
                    "path": "<Gamepad>/buttonWest",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Interact",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "89d57d47-ed34-4fe2-a234-4843efd22cf4",
                    "path": "<Keyboard>/c",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "SwapCam",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "65af0407-21f3-488c-9b61-7a82ac361053",
                    "path": "<Gamepad>/dpad/up",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "SwapCam",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "431bb81f-53f2-4a0b-a250-ea149a7ae8c9",
                    "path": "<Mouse>/leftButton",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Fire Laser",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "6e427cb4-1c71-47a9-85ae-8362124808f2",
                    "path": "<Gamepad>/buttonSouth",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Fire Laser",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "8a926a23-6632-48ba-a482-6deb70be9321",
                    "path": "<Keyboard>/1",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Fire Missle",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "689e5971-e2b8-4930-8593-1f709f6ecb89",
                    "path": "<Gamepad>/leftStickPress",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Fire Missle",
                    "isComposite": false,
                    "isPartOfComposite": false
                }
            ]
        },
        {
            "name": "PlayerControls",
            "id": "a736e4c8-59a4-4613-8c53-9a0c14770165",
            "actions": [
                {
                    "name": "Thrust",
                    "type": "PassThrough",
                    "id": "55de382a-5e31-4292-b201-fdd2140e2131",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "PitchYaw",
                    "type": "PassThrough",
                    "id": "a769f292-9a85-4e2a-a56d-1b988718f497",
                    "expectedControlType": "Vector2",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Strafe",
                    "type": "PassThrough",
                    "id": "b006b58a-2d4c-4d4d-bfd1-0aeb29c61465",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "downUp",
                    "type": "PassThrough",
                    "id": "e5da07cb-2d67-4586-82e6-ab70e38c41c1",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Roll",
                    "type": "PassThrough",
                    "id": "a5a75033-3089-41fd-a0b5-e19453aeb89d",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "",
                    "initialStateCheck": false
                },
                {
                    "name": "Boost",
                    "type": "PassThrough",
                    "id": "d9b79e73-133f-4058-9b51-e53a09d55e9a",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "Press",
                    "initialStateCheck": false
                },
                {
                    "name": "Interact",
                    "type": "PassThrough",
                    "id": "18faa76e-4cbf-4c7a-b28c-95f904fdfd41",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "Press",
                    "initialStateCheck": false
                },
                {
                    "name": "SwapCam",
                    "type": "PassThrough",
                    "id": "9967eb5f-4cab-42f2-b115-50e06506b489",
                    "expectedControlType": "Button",
                    "processors": "",
                    "interactions": "Press",
                    "initialStateCheck": false
                }
            ],
            "bindings": [
                {
                    "name": "",
                    "id": "2b5d6d2f-877e-4673-af15-b364aa348f72",
                    "path": "",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Thrust",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "ThrustKB",
                    "id": "43d95eab-8a60-4a0f-bd17-6f282e6261e4",
                    "path": "1DAxis",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Thrust",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "negative",
                    "id": "b8f94cb0-7efa-449c-a24a-a51db3f82e40",
                    "path": "<Keyboard>/s",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Thrust",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "positive",
                    "id": "6702d749-9f20-47d3-8385-6aae0a635bd0",
                    "path": "<Keyboard>/w",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Thrust",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "ThrustController",
                    "id": "957d50e0-17fa-40d7-9c13-2d7989965d84",
                    "path": "1DAxis",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Thrust",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "negative",
                    "id": "e57fbe8c-b527-4c8e-bf3d-f591adfbe876",
                    "path": "<Gamepad>/leftStick/down",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Thrust",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "positive",
                    "id": "4de47d05-6938-485b-a524-ab0c182ee0fe",
                    "path": "<Gamepad>/leftStick/up",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Thrust",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "StrafeKB",
                    "id": "7f08a2a7-deab-4cbe-a537-5c0373eddf99",
                    "path": "1DAxis",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Strafe",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "negative",
                    "id": "b94fefa6-a3e5-4209-9f36-0c7fb19e04a6",
                    "path": "<Keyboard>/a",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Strafe",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "positive",
                    "id": "dc266c9e-a8a5-404a-9d7d-cedefff68b97",
                    "path": "<Keyboard>/d",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Strafe",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "StrafeController",
                    "id": "e1b4e646-f9f1-4a92-8fd0-3138da415dc8",
                    "path": "1DAxis",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Strafe",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "negative",
                    "id": "4c1d3d6d-7b8e-44b8-b524-e2d3693a3ac5",
                    "path": "<Gamepad>/leftStick/left",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Strafe",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "positive",
                    "id": "60a041a2-ae0d-4b19-b4fb-68dd00d9be1f",
                    "path": "<Gamepad>/leftStick/right",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Strafe",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "downUpKB",
                    "id": "b9b61b29-dd5b-48c3-8adb-8e9f1dcfb534",
                    "path": "1DAxis",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "downUp",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "negative",
                    "id": "c219c465-a71f-422a-abba-025101541d9a",
                    "path": "<Keyboard>/leftCtrl",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "downUp",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "positive",
                    "id": "bb2d0c25-6f92-4633-a2cb-2b4b64a967c3",
                    "path": "<Keyboard>/space",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "downUp",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "downUpController",
                    "id": "7ec61a2c-dd74-4691-9a94-3d7ea924b123",
                    "path": "1DAxis",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "downUp",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "negative",
                    "id": "dfd20044-3f5e-4f13-8050-7bf01a8f1ae0",
                    "path": "<Gamepad>/leftShoulder",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "downUp",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "positive",
                    "id": "28561126-a188-4328-9877-de639ffaa495",
                    "path": "<Gamepad>/rightShoulder",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "downUp",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "rollKB",
                    "id": "e3cd915a-89fa-4368-9fbb-14e3c2fd35ba",
                    "path": "1DAxis",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Roll",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "negative",
                    "id": "edb80a37-cc4c-4a3d-8af2-27454fef980a",
                    "path": "<Keyboard>/q",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Roll",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "positive",
                    "id": "e37595c7-2d10-4093-9f7a-4b16c0ac0946",
                    "path": "<Keyboard>/e",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Roll",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "rollController",
                    "id": "e8eea6e8-ad5f-4e8a-a547-494e4dedcbea",
                    "path": "1DAxis",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Roll",
                    "isComposite": true,
                    "isPartOfComposite": false
                },
                {
                    "name": "negative",
                    "id": "77081c40-d120-43b9-bb88-eef0dc62204f",
                    "path": "<Gamepad>/leftTrigger",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Roll",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "positive",
                    "id": "ff171cf0-a24b-48f7-80a6-65513b354a34",
                    "path": "<Gamepad>/rightTrigger",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Roll",
                    "isComposite": false,
                    "isPartOfComposite": true
                },
                {
                    "name": "",
                    "id": "b837ab88-4769-4160-9469-ce1bcb88bbd9",
                    "path": "<Keyboard>/leftShift",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Boost",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "c09bcf0c-b049-468e-a3b8-c2e7dd06344f",
                    "path": "<Gamepad>/buttonEast",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Boost",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "9248b19d-4313-4c60-84bb-f556e8171aea",
                    "path": "<Keyboard>/f",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Interact",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "d4c70234-54b9-429e-a28d-c0d9b5c380a0",
                    "path": "<Gamepad>/buttonWest",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "Interact",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "3d15728c-69b8-4231-8d65-b319ae11d3d1",
                    "path": "<Keyboard>/c",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "SwapCam",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "2df2cdc2-befc-4059-a160-04f4e08fd9ad",
                    "path": "<Gamepad>/dpad/up",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "SwapCam",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "b58adafd-a103-4a34-9036-3f19ad012f1c",
                    "path": "<Gamepad>/rightStick",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "PitchYaw",
                    "isComposite": false,
                    "isPartOfComposite": false
                },
                {
                    "name": "",
                    "id": "7b0ea2f4-30d8-49ef-ac92-21d61b698a93",
                    "path": "<Mouse>/delta",
                    "interactions": "",
                    "processors": "",
                    "groups": "",
                    "action": "PitchYaw",
                    "isComposite": false,
                    "isPartOfComposite": false
                }
            ]
        }
    ],
    "controlSchemes": []
}