# XR Interaction Toolkit (ZENVA course)



\- link: \[Course Link](https://academy.zenva.com/lesson/introduction-513/)

\- Author: Daniel Buckley

\- note: These notes and code are me following along with the course, and may not reflect the author 100%

\- as always, please refer back to the original author's work!



\## Unity, quick reminder of QWERTY tools:



| Command | Tool/Mode | Description |

| :--- | :--- | :--- |

| \*\*Q\*\* | Hand | For panning and navigating the Scene view. |

| \*\*W\*\* | Move | For translating (moving) objects along their X, Y, and Z axes. |

| \*\*E\*\* | Rotate | For rotating objects around their local or global axes. |

| \*\*R\*\* | Scale | For uniformly or non-uniformly scaling (stretching/resizing) objects. |

| \*\*T\*\* | Rect Transform | Primarily used for UI elements and 2D objects. |

| \*\*Y\*\* | Transform | A combination of the Move, Rotate, and Scale tools in a single gizmo. |



\# Housekeeping

\- I am using 6000.3.7f1 LTS.  (update: had to upgrade to - 6000.3.8f1 LTS. Too many bugs)

\- this is later than the one in the course (he is using: 6000.0.24f1)

\- (probably good enough, but aware)

\- In my notes, I  refer to panels as:



| \&nbsp; Panel Name \&nbsp; | \&nbsp; Short Form \&nbsp; | \&nbsp; Description \&nbsp; |

| :--- | :--- | :--- |

| \&nbsp; Scene | \&nbsp; \*\*S\*\* | \&nbsp; Where you can drag objects and build 3D scene |

| \&nbsp; Hierarchy | \&nbsp; \*\*H\*\* | \&nbsp;  See objects and their inheritance |

| \&nbsp; Inspector | \&nbsp; \*\*I\*\* | \&nbsp; Detailed information on components for selected object \&nbsp;|

| \&nbsp; Project | \&nbsp; \*\*P\*\* | \&nbsp;  See resources relative to file directory |

| \&nbsp; Game | \&nbsp; \*\*G\*\* | \&nbsp; Where the game is played |



\# Preamble

\- author discusses how to install unity

\# Create Project

\- Projects:

&nbsp;   - \[NEW Project]

&nbsp;   - 6000.3.0f1

&nbsp;   - Universal 3D

&nbsp;   - name it `XRInteractionToolkitCourse`

\- Don't use cloud! Not sure why Unity wants my stuff, but I will manage this with git myself

\- after a few moments it will create `C:\\Users\\steve\\unity\_projects\\XRInteractionToolkitCourse`

\- URP, press the \[Remove Readme Assets] button

\- Open Package Manager (Window, Package Management, Package Manager)

&nbsp;   - observe that comes "pre-installed"

&nbsp;   - remove JetBrains (I don't have that)

&nbsp;   - remove Visual Scripting (it adds things to project that are , for us, unnecessary overhead)

&nbsp;   - close Package Manager

\- set up git (I am using powershell; you do you)

<pre>

&nbsp;    set-location 'C:\\Users\\steve\\unity\_projects\\XRInteractionToolkitCourse\\'

&nbsp;    Set-Content -Path README.md -Value "in progress, not done yet!"

&nbsp;    # (copy a .gitignore from a previous project or internet)

&nbsp;    git init

&nbsp;    git add .

&nbsp;    git commit -m "Initial commit - new project, readme"

</pre>



\# Setup Environment

\- for some reason, author has tutorial stuff. I told the URP to delete it and its readme.

\- ah, author wanted to have the InputSystem\_Actions that come with.

\- to generate a InputSystem\_Actions

&nbsp;   - Edit-Project Settings

&nbsp;   - select Input System Package

&nbsp;   - \[Create a new project-wide Action Asset]  button, if required

\- anyway, drag InputSystem\_Actions into p, Assets, Settings

\- grab assets

\- \[assets](https://academy.zenva.com/wp-content/uploads/2025/12/Assets-XR-Interaction-Toolkit.zip)

\- you will need to download and extract those files

\- drag the folders into P, Assets  (he grabs everything but the Assets Licenses.txt)

\- side note, if we do distribute the courses result, we should give credit, yes?

\- author verifies that the P, Assets, Materials, Wood has the textures assigned

\- (has he had import issues in the past?)

\- author enables his gride in his Scene, but mine was already enabled

\- in P, Assets, Models, drag Platform into H

\- P, Assets, Materials, Tiles; drag Tiles onto the Platform in Scene

\- H, Platform

&nbsp;   - Position: 0 0 0

\- in H, create empty, rename `\_Environment`

\- drag everything except Main Camera into `\_Environment`

\- P, Assets, Models; drag Kitchen into H

&nbsp;   - Position: 0 0 1

&nbsp;   - Rotation: 0 -90 0

\- P, Assets, Models; double click Kitchen

\- if you get a popup to edit your "fbx", press escape for now

\- in I, press \[Materials] button

\- observe/find Remapped Materials, should be 4 we can assign

&nbsp;   - ChoppingBoard: find Wood, select the "light" one

&nbsp;   - Marble: find Marble, select the marbly one

&nbsp;   - Metal: find Wood, select the shiny one

&nbsp;   - Wood: find Wood, select the "dark one"

&nbsp;   - click \[Apply]

\- OK, we need to do this for the Knife model, Pot Model, Sausage

\- I can't do this to watermelon? I dunno? 

\- I dragged into scene, applied Watermelon , and made a prefab

\- LOL - and author tells us to skip watermelon for now. Oh.

\- Window - Rendering - Lighting

\- dock the window beside the I

\- select Environment Tab

\- P, Assets, SkyBox; drag SkyBox into I, SkyBox Material

\- create a Reflection Probe in H; 

&nbsp;   - Position: 0 1.3 0

&nbsp;   - Type: Baked (mine was)

&nbsp;   - \[Bake]

&nbsp;   - Position: 0 5 0

&nbsp;   - move the Reflection Probe into \_Environment



\# Installing XR Interaction Toolkit

\- \[link](https://academy.zenva.com/lesson/installing-xr-interaction-toolkit-26937f7ceeea36/)

\- Window - Package Management - Package Manager

\- Unity Registry

&nbsp;   - provides a long list of packages that unity offers

&nbsp;   - Search for XR Inter

\- and don't install that

\- instead, look for VR.

&nbsp;   - it has 3 packages

&nbsp;   - one of the packages is XR Interaction

&nbsp;   - \[Install]

&nbsp;   - I got a signature error, specifically on XR Legacy Input Helpers

&nbsp;   - no idea what that means, but Manage and Remove? Nope. Dependencies.

\- select XR Interaction Toolkit

&nbsp;   - find Samples panel

&nbsp;   - Starter Assets \[Import]

\- I got a Project Validation. So Fix All



\- ok, back to Scene

\- Move H, Main Camera, Position: 0, 1.25, -0.3

\- Edit - Project Settings - XR Plug-In Management

&nbsp;   - select Oculus and OpenXR 

\- Restart



\## SIDE BAR BEGINS

<pre>

Important

All 6.3 builds before 6000.3.5f2 have a known issue where the Package Manager can 

report packages as invalid, even though they have a valid package signature.

This issue is fixed in 6000.3.5f2 and later. Update to one of these builds to address 

the issue.

For information about this issue in other versions of the Unity Editor, refer to 

Unity Discussions.

For more information about package signatures, refer to Package signatures.

</pre>

\- so, this is painful

\- installing 6000.3.8f1

\- fix up the VR package import

\- (sigh, probably would have been easier to start over)

\## SIDE BAR ENDS

\- P, Assets, Settings, click PC\_Renderer

\- \[ ] Screen Space Ambient Occlusion   (disable for VR, too much processor cost)

\- connect headset, press play, and wonder why it didn't work :-)

\- well, sorta worked, static position is sorta nauseating

\- but author knows and is working on it - next lesson

\- oh, as an aside, I use Virtual Desktop Streamer. It works.





\# XR Rig - Part 1

\- in H, select Camera

&nbsp;   - in I, new component, "tracked pose driver (Input System)"

&nbsp;   - Position Input, select +, add binding

&nbsp;        - double click <No Binding>, Path, XR HMD, centerEyePosition

&nbsp;   - Rotation Input, select +, add binding

&nbsp;        - double click <No Binding>, Path, XR HMD, deviceRotation         

&nbsp;   - Tracking State Input, select +, add binding

&nbsp;        - double click <No Binding>, Path, XR HMD, trackingState        

\- H, create empty, rename XR Origin, Position 0 0 0

\- drag Main Camera into XR Origin

&nbsp;   - Position: 0 1.2 0

\- H, XR Origin, create empty, rename Left Hand

&nbsp;   - add component tracked pose driver (input system)

&nbsp;   - Position Input, select +, add binding

&nbsp;        - double click <No Binding>, Path, XR Controller, XR Controller(Left Hand), device Position

&nbsp;   - Rotation Input, select +, add binding

&nbsp;        - double click <No Binding>, Path, XR Controller, XR Controller(Left Hand), device Rotation

&nbsp;   - Tracking State Input, select +, add binding

&nbsp;        - double click <No Binding>, Path, XR Controller, XR Controller(Left Hand), tracking State Rotation



\- right click H, XR Origin, LeftHand. Add 3D, sphere, rename to HandModel, disable collider, 0.1 scale



\- select H, XR Origin, Main Camera

&nbsp;   - Projection, Clipping Planes Near: 0.01 (which is 0)

\- Repeat what we did got Left hand, but for right hand

\- and test



\# XR Rig - Part 2



\- verify that we did right hand correctly (we did)

\- next, select XR Origin in H

&nbsp;   - Add Component; XR Origin

&nbsp;   - on H, create empty, rename Camera Offset, Position 0 1.35 0

&nbsp;   - set the Main Camera as a child, Position 0 0 0

\- select XR Origin

&nbsp;   - assign "that" as Camera Floor offset. (Camera Offset)

&nbsp;   - assign Main Camera as Camera

&nbsp;   - Camera Y Offset: 1.35

&nbsp;   - (note: positions will vary based on head set and wearer)



\# Quiz



\###1. What is the most efficient way to persistently assign materials to a 3D model with multiple material slots?



&nbsp;  \[O] Dragging the material onto the object in the Scene View.

&nbsp;  \[X] Assigning materials in the model's Inspector under the Materials tab.

&nbsp;  \[O] Writing a custom Material organizer script.

&nbsp;  \[O] Applying materials only to the parent GameObject.



\###2. What is the main function of the Reflection Probe in a Unity scene?

&nbsp;  \[O] To calculate dynamic real-time shadows.

&nbsp;  \[O] To reduce the polygon count of complex models.

&nbsp;  \[X] To capture a 360-degree image of the scene and apply realistic reflections to nearby surfaces.

&nbsp;  \[O] To serve as the anchor point for teleportation.



\###3. Which component translates physical movement data from the XR device to update a virtual GameObject’s position and rotation?

&nbsp;  \[O] Global Volume

&nbsp;  \[O] XR Origin

&nbsp;  \[O] Directional Light

&nbsp;  \[X] Tracked Pose Driver



\###4. Enabling plugins (like Oculus or OpenXR) in XR Plugin Management serves what core purpose?

&nbsp;  \[O] It determines the size of the imported Starter Assets.

&nbsp;  \[X] It specifies which VR hardware platforms Unity should communicate with and support.

&nbsp;  \[O] It automatically adjusts the Camera's Near Clipping Plane.

&nbsp;  \[O] It manages non-VR keyboard and mouse input.



\###5. The Project Validation tool optimizes project settings for high-performance VR by identifying and fixing required configurations.

&nbsp;  \[X] True

&nbsp;  \[O] False



\###6. Why is the Main Camera’s Near Clipping Plane adjusted to a very small value in a VR setup?

&nbsp;  \[O] To improve overall scene frame rate.

&nbsp;  \[O] To correctly register the player's height.

&nbsp;  \[O] To utilize the Reflection Probe data better.

&nbsp;  \[X] To ensure that nearby objects do not get clipped when close to the player's face.



\###7. What is the main architectural role of the XR Origin component on the root player GameObject?

&nbsp;  \[X] It acts as a high-level manager, defining central player settings and key references.

&nbsp;  \[O] It is solely responsible for reading the headset's positional data.

&nbsp;  \[O] It prevents unwanted physics collisions for the controller models.

&nbsp;  \[O] It manages the visual display quality.



\# Grab Interactables - Part 1

\- P, Models; drag the Pot into H

\- Pot, Position: -0.14 0.802 0.6 (so its on the counter)

\- rename Pot to Model

\- create Empty, rename to Pot

\- drag Model into Pot

\- Pot, Model should be at 0 0 0

\- Pot Position at -0.14 0.802 0.6 (so its on the counter)

\- Pot, Model; add mesh collider, \[x] convex

\- OR, remove that, and use two colliders

&nbsp;   - Box Collider 1, resize to fit the pot

&nbsp;   - Box Collider 2, resize to fit the handle

\- comment: the two box collider approach is a massive pain in the ass to set up

\- practice practice practice!

\- select H, Pot

&nbsp;   - add component : RigidBody

&nbsp;   - Is Kinematic \[x]

&nbsp;   - add component: XR Grab Interactable

\- H, right click, XR, Interaction Manager

&nbsp;   - drag to just under the SampleScene in H (so drag to top)

\- H, Pot

&nbsp;   - drag XR Interaction Manager into Interaction Manager (optional? unity will figure it out? hmm)

&nbsp;   - leave the Layer mask as default for now

&nbsp;   - leave Colliders empty for now, unity will figure it out (??)

\- H, XR Origin, Left Hand; rclick, XR ... note the type of  Interactors... Direct Interactor for grab

&nbsp;   - Position: 0 0 0 

&nbsp;   - assign (or don't if you trust unity) Interaction Manager

&nbsp;   - set Handedness: Left

&nbsp;   - observe Input Configuration; author discusses select (grip) vs activate (trigger)

&nbsp;   - click top Select Input picker, search XRI Left Interaction/Select

&nbsp;   - click bottom Select Input picker, search XRI Left Interaction/Select Value

&nbsp;   - click top Activate Input picker, search XRI Left Interaction/Activate

&nbsp;   - click bottom Activate Input picker, search XRI Left Interaction/Activate Value

\- select H, XR Origin

&nbsp;   - add component, Input Action Manager

&nbsp;   - add element to Action Assets

&nbsp;   - make element XRI Default Input Actions

\- test, should have left hand functionality

\- now (you guessed it) do the same thing for the right hand

\### Challenge: add right hand

\- H, XR Origin, Left Hand; rclick, XR ... note the type of  Interactors... Direct Interactor for grab

&nbsp;   - Position: 0 0 0 

&nbsp;   - assign (or don't if you trust unity) Interaction Manager

&nbsp;   - set Handedness: Right

&nbsp;   - observe Input Configuration; author discusses select (grip) vs activate (trigger)

&nbsp;   - click top Select Input picker, search XRI Right Interaction/Select

&nbsp;   - click bottom Select Input picker, search XRI Right Interaction/Select Value

&nbsp;   - click top Activate Input picker, search XRI Right Interaction/Activate

&nbsp;   - click bottom Activate Input picker, search XRI Right Interaction/Activate Value

\- Test run; um, no gravity on pot, also can't be dropped. Maybe this is OK?





\# Grab Interactables - Part 2

\- watching the author demo; matches my experience, no gravity on the pot

\- select H, Pot

&nbsp;    - Attach Transform:  { currently none, so it grabs at 0 0 0 of pot)

\- in H, Pot, create empty, rename AttachTransform 

&nbsp;    - Position: (up to the handle) say, 0.25 0.1 0

&nbsp;    - Rotation: 0 -90 0

\- select H, Pot

&nbsp;    - drag the AttachTransform  into AttachTransform

\- test, not is snaps to the AttachTransform on pickup

\- ok, if you want to grab it wherever you click, Use Dynamic Attach \[x]

\- on H, create empty object called Watermelon 

\- drag in P, Assets, Models, Watermelon into H, Watermelon

&nbsp;    - rename to be Model

&nbsp;    - Position 0 0 0, 

\- Move "it over here" (H, Watermelon) to Position: 0.5 0.831 0.62

\- in H, Watermelon, Model

&nbsp;    - I, Materials, ELement0, search and find watermelon material

&nbsp;    - add component Mesh collider, enable convex

\- on H, Watermelon

&nbsp;    - add RigidBody component, Is Kinematic \[x] (for now)

&nbsp;    - add component, XR Grab Interactable

&nbsp;    - Use Dynamic Attach



\# Physical Environment

\- select H, \_Environment, Platform

&nbsp;    - add component Mesh Collider

\- select H, Kitchen, CounterTop

&nbsp;    - add component Mesh Collider

\- select H, Kitchen, ChoppingBoard

&nbsp;    - add component Box Collider

\- select H, Kitchen, Base

&nbsp;    - add component Mesh Collider

\- select H, Kitchen, Faucet

&nbsp;    - add component Mesh Collider

\- select H, Kitchen, FaucetHandle

&nbsp;    - add component Mesh Collider

\- select H, Kitchen, Sink

&nbsp;    - add component Mesh Collider

\- select H, Pot

&nbsp;    - Disable Is Kinematic

\- select H, Watermelon

&nbsp;    - Disable Is Kinematic

\- notes: the Pot and Watermelon will now drop. They will collide with items above



\# Ray Interactor

\- like a ray that you can point and "interact" with objects

\- rclick: H, XROrgin, LeftHand, XR-RayInteractor

\- select H, XROrgin, LeftHand, XR-RayInteractor

&nbsp;    - Handedness: Left

&nbsp;    - UI Interaction \[ ]   (for now)

&nbsp;    - Translate Input (how close/far to move object): XRI Left Interaction/Translate Manipulation

&nbsp;    - Rotate Input: XRI Left Interaction/Rotate Manipulation

&nbsp;    - Directional Input, Scale Toggle Input and Scale Over Time Input;  leave as None

&nbsp;    - scroll down to Input Configuration

&nbsp;    - Select Input top: XRI Left Interaction/Select

&nbsp;    - Select Input bottom: XRI Left Interaction/Select Value

&nbsp;    - Activate Input top: XRI Left Interaction/Activate

&nbsp;    - Activate Input bottom: XRI Left Interaction/Activate Value

\- test, should be able to point, grip, and move in and out (joy) and ungrip and drop

\- BUG: my watermelon was not working correctly. I went back and redid it, works now.

&nbsp;    - (basically I put rigidbody on the model instead of the watermelon)

\- BUG: my pot is dropping a pixel to deep into things

&nbsp;    - so the box collider on the pot needed to be stretched on the Y

&nbsp;    - Vector3(0.24629952,0.133671463,0.24000001)

\- H XR Origin, Left Hand, Ray Indicator

&nbsp;    - Force Grab \[x]  ( will cause objects to snap to your hand position)

&nbsp;    - test that

&nbsp;    - Width Curve

&nbsp;    - Colors: lose the gradients and go green for valid, blue for invalid

&nbsp;    - (leave blocked alone)

\- Tested, everything is working (hazzah)

\- Next, challenge is to do all this again for the right hand

\- I just copied Ray Interactor on Left over to Right, and changed stuff.

\- Test, seems to work



\# Faucet Interaction

\- create H, Empty Object - rename FaucetInteraction

&nbsp;    - for now, drag up in general vicinity of Faucet

&nbsp;    - add a box collider to the FaucetInteraction

&nbsp;    - Position: 0.0586 0.887 1.3833

&nbsp;    - Rotation: 0 0 0

&nbsp;    - Scale: 1 1 1

&nbsp;    - Center: 0 0 0

&nbsp;    - Size: 0.04406889 0.1203088 0.08518425

&nbsp;    - add a XR Simple Interactable  (triggers if interacted with)

&nbsp;    - assign collider 

\- P, Assets, Water Particle; drag WaterParticle prefab into H

&nbsp;    - "align it right about here" Position: 0 0.9779 1.0733

&nbsp;    - Play on Awake \[ ]

\- P, Assets create folder called Scripts

&nbsp;    - cresate new script Faucet

\- H, FaucetInteraction

&nbsp;    - drag script in

\- open script in Visual Studio

\- delete Start and Update methods; we don't need them

<pre>

using UnityEngine;



public class Faucet : MonoBehaviour

{

&nbsp;   private bool isOn;



&nbsp;   \[SerializeField]

&nbsp;   private Transform tapObject;

&nbsp;   \[SerializeField]

&nbsp;   private Vector3 offRotation;

&nbsp;   \[SerializeField]

&nbsp;   private Vector3 onRotation;

&nbsp;   \[SerializeField]

&nbsp;   private ParticleSystem waterParticle;



&nbsp;   private void Start()

&nbsp;   {

&nbsp;       TurnOff();

&nbsp;   }

&nbsp;   public void Toggle()

&nbsp;   {

&nbsp;       if (isOn)

&nbsp;       {

&nbsp;           TurnOff();

&nbsp;       }

&nbsp;       else

&nbsp;       {

&nbsp;           TurnOn();

&nbsp;       }

&nbsp;   }

&nbsp;   void TurnOn()

&nbsp;   {

&nbsp;       isOn = true;

&nbsp;       waterParticle.Play();

&nbsp;       tapObject.localEulerAngles = onRotation;

&nbsp;   }

&nbsp;   void TurnOff()

&nbsp;   {

&nbsp;       isOn = false;

&nbsp;       waterParticle.Stop();

&nbsp;       tapObject.localEulerAngles = offRotation;

&nbsp;   }

}

</pre>

\- save, unity

\- Lock

\- select H, Kitchen, FaucetHandle drag into Tab Object

\- Off Rotation 0 0 0

\- On Rotation 0 0 40

\- select H, WaterParticle drag into Water Particle

\- UnLock

\- Select Entered ; +

\- drag in Faucet script

\- select Toggle





\# Quiz



\###1. Which component allows a GameObject to be picked up and held by a user?



&nbsp;   \[ ] XR Simple Interactable

&nbsp;   \[ ] Rigidbody

&nbsp;   \[X] XR Grab Interactable

&nbsp;   \[ ] Input Action Manager

&nbsp;   \[ ] XR Direct Interactor



\###2. To be physically interactive, an object requires both a Collider and a Rigidbody component.

&nbsp;   \[X] True

&nbsp;   \[ ] False



\###3. Which interactor component is used primarily for near-field interaction (grabbing by touching)?

&nbsp;   \[ ] XR Ray Interactor

&nbsp;   \[ ] XR Interactor Line Visual

&nbsp;   \[ ] XR Grab Interactable

&nbsp;   \[X] XR Direct Interactor



\###4. If a Rigidbody has the Is Kinematic property enabled, the object is controlled by the physics engine and affected by gravity.

&nbsp;   \[ ] True

&nbsp;   \[X] False



\###5. To define a fixed location (e.g., a handle) where the hand snaps when grabbing an object, which XR Grab Interactable property is used?

&nbsp;   \[X] Attach Transform

&nbsp;   \[ ] Select Action

&nbsp;   \[ ] Use Dynamic Attach

&nbsp;   \[ ] Rigidbody



\###6. The Use Dynamic Attach property is ideal for tools or weapons that require a fixed, specific grab point (e.g., a handle)

&nbsp;   \[ ] True

&nbsp;   \[X] False



\###7. What is the primary function of the XR Ray Interactor?

&nbsp;   \[ ] Manipulating UI elements only

&nbsp;   \[X] Ranged interaction (pointing at distant objects)

&nbsp;   \[ ] Near-field interaction based on collision

&nbsp;   \[ ] Defining an object’s custom grab rotation



\###8. Static environment objects (like the floor) that block physics-enabled items require an XR Grab Interactable component.

&nbsp;   \[ ] True

&nbsp;   \[X] False



\###9. Which component is required in the scene to manage and coordinate all controller input actions (like Select and Activate)?

&nbsp;   \[ ] XR Origin

&nbsp;   \[ ] Interaction Manager

&nbsp;   \[X] Input Action Manager

&nbsp;   \[ ] Rigidbody



\###10. The XR Simple Interactable component is used for triggering events rather than for pick-up and hold mechanics.

&nbsp;   \[X] True

&nbsp;   \[ ] False





\# Locomotion

\- select H, XR Origin

&nbsp;   - add component Character Controller

&nbsp;   - Radius: 0.1

&nbsp;   - Height: 1.35 (match the camera height)

&nbsp;   - X: 0  Y: 1.35/2 Z: 0

\- select H, XR Origin; create empty game object rename to Locomotion

&nbsp;   - add component Locomotion Mediator

&nbsp;   - it will automatically find XR Origin

&nbsp;   - make sure Use Character Controller \[x]  (it should be)

\- select H, XR Origin, Locomotion; create empty rename Move

&nbsp;   - add component Continuous Move Provider

&nbsp;   - drag Locomotion into Mediator

&nbsp;   - Forward Source: (drag in) Main Camera

&nbsp;   - Left Hand Move Input: XRI Left Locomotion/Move

&nbsp;   - Right Hand Move Input: None  (no movement on right hand)

\- save, press play

\- select H, XR Origin, Locomotion; create empty rename Turn

&nbsp;   - add component Snap Turn Provider

&nbsp;   - drag Locomotion into Mediator

&nbsp;   - note this one turns you in 45degree snaps (configurable)

&nbsp;   - Left Hand Turn: None

&nbsp;   - Right Hand Turn Input: XRI Right Locomotion/Snap Turn





&nbsp;   - add component Continuous Turn Provider

&nbsp;   - drag Locomotion into Mediator

&nbsp;   - Left Hand Turn: None

&nbsp;   - Right Hand Turn Input: XRI Right Locomotion/Turn

&nbsp;

&nbsp;   - YOU CANNOT USE BOTH, SO DEACTIVATE ONE

&nbsp;   - disable Continuous for now





\# Quiz



\###1. What is the main role of the Character Controller component when added to the XR Origin for VR locomotion?



&nbsp;   \[ ] To enable full Rigidbody physics simulation.

&nbsp;   \[ ] To set the maximum speed for continuous turning.

&nbsp;   \[ ] To define the camera offset height.

&nbsp;   \[X] To provide a simple physical presence (collider) for collision without relying on full physics.



\###2. Which component serves as the central manager coordinating all Locomotion Providers and the Character Controller?



&nbsp;   \[ ] Continuous Move Provider

&nbsp;   \[ ] XR Origin

&nbsp;   \[X] Locomotion Mediator

&nbsp;   \[ ] Input Action Manager



\###3. To ensure the player moves in the direction they’re looking, which object is typically assigned to the Continuous Move Provider’s “Forward Source” property?



&nbsp;   \[ ] The Character Controller GameObject

&nbsp;   \[X] The Main Camera

&nbsp;   \[ ] The Locomotion Mediator

&nbsp;   \[ ] The Collider component



\###4. Snap Turning is commonly preferred over Continuous Turning because it helps mitigate motion sickness for many users.



&nbsp;   \[X] True

&nbsp;   \[ ] False



\###5. In the standard XR input setup, what function is assigned to the input action reference for the left-hand joystick?



&nbsp;   \[ ] Managing rotational speed for turning.

&nbsp;   \[ ] Triggering snap rotation.

&nbsp;   \[X] Handling forward, backward, and sideways translation (movement).

&nbsp;   \[ ] Activating the comfort vignette effect.











































