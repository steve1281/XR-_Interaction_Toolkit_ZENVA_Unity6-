# XR Interaction Toolkit (ZENVA course)

- link: [Course Link](https://academy.zenva.com/lesson/introduction-513/)
- Author: Daniel Buckley
- note: These notes and code are me following along with the course, and may not reflect the author 100%
- as always, please refer back to the original author's work!

## Unity, quick reminder of QWERTY tools:

| Command | Tool/Mode | Description |
| :--- | :--- | :--- |
| **Q** | Hand | For panning and navigating the Scene view. |
| **W** | Move | For translating (moving) objects along their X, Y, and Z axes. |
| **E** | Rotate | For rotating objects around their local or global axes. |
| **R** | Scale | For uniformly or non-uniformly scaling (stretching/resizing) objects. |
| **T** | Rect Transform | Primarily used for UI elements and 2D objects. |
| **Y** | Transform | A combination of the Move, Rotate, and Scale tools in a single gizmo. |

# Housekeeping
- I am using 6000.3.7f1 LTS.  (update: had to upgrade to - 6000.3.8f1 LTS. Too many bugs)
- this is later than the one in the course (he is using: 6000.0.24f1)
- (probably good enough, but aware)
- In my notes, I  refer to panels as:

| &nbsp; Panel Name &nbsp; | &nbsp; Short Form &nbsp; | &nbsp; Description &nbsp; |
| :--- | :--- | :--- |
| &nbsp; Scene | &nbsp; **S** | &nbsp; Where you can drag objects and build 3D scene |
| &nbsp; Hierarchy | &nbsp; **H** | &nbsp;  See objects and their inheritance |
| &nbsp; Inspector | &nbsp; **I** | &nbsp; Detailed information on components for selected object &nbsp;|
| &nbsp; Project | &nbsp; **P** | &nbsp;  See resources relative to file directory |
| &nbsp; Game | &nbsp; **G** | &nbsp; Where the game is played |

# Preamble
- author discusses how to install unity
# Create Project
- Projects:
    - [NEW Project]
    - 6000.3.0f1
    - Universal 3D
    - name it `XRInteractionToolkitCourse`
- Don't use cloud! Not sure why Unity wants my stuff, but I will manage this with git myself
- after a few moments it will create `C:\Users\steve\unity_projects\XRInteractionToolkitCourse`
- URP, press the [Remove Readme Assets] button
- Open Package Manager (Window, Package Management, Package Manager)
    - observe that comes "pre-installed"
    - remove JetBrains (I don't have that)
    - remove Visual Scripting (it adds things to project that are , for us, unnecessary overhead)
    - close Package Manager
- set up git (I am using powershell; you do you)
<pre>
     set-location 'C:\Users\steve\unity_projects\XRInteractionToolkitCourse\'
     Set-Content -Path README.md -Value "in progress, not done yet!"
     # (copy a .gitignore from a previous project or internet)
     git init
     git add .
     git commit -m "Initial commit - new project, readme"
</pre>

# Setup Environment
- for some reason, author has tutorial stuff. I told the URP to delete it and its readme.
- ah, author wanted to have the InputSystem_Actions that come with.
- to generate a InputSystem_Actions
    - Edit-Project Settings
    - select Input System Package
    - [Create a new project-wide Action Asset]  button, if required
- anyway, drag InputSystem_Actions into p, Assets, Settings
- grab assets
- [assets](https://academy.zenva.com/wp-content/uploads/2025/12/Assets-XR-Interaction-Toolkit.zip)
- you will need to download and extract those files
- drag the folders into P, Assets  (he grabs everything but the Assets Licenses.txt)
- side note, if we do distribute the courses result, we should give credit, yes?
- author verifies that the P, Assets, Materials, Wood has the textures assigned
- (has he had import issues in the past?)
- author enables his gride in his Scene, but mine was already enabled
- in P, Assets, Models, drag Platform into H
- P, Assets, Materials, Tiles; drag Tiles onto the Platform in Scene
- H, Platform
    - Position: 0 0 0
- in H, create empty, rename `_Environment`
- drag everything except Main Camera into `_Environment`
- P, Assets, Models; drag Kitchen into H
    - Position: 0 0 1
    - Rotation: 0 -90 0
- P, Assets, Models; double click Kitchen
- if you get a popup to edit your "fbx", press escape for now
- in I, press [Materials] button
- observe/find Remapped Materials, should be 4 we can assign
    - ChoppingBoard: find Wood, select the "light" one
    - Marble: find Marble, select the marbly one
    - Metal: find Wood, select the shiny one
    - Wood: find Wood, select the "dark one"
    - click [Apply]
- OK, we need to do this for the Knife model, Pot Model, Sausage
- I can't do this to watermelon? I dunno? 
- I dragged into scene, applied Watermelon , and made a prefab
- LOL - and author tells us to skip watermelon for now. Oh.
- Window - Rendering - Lighting
- dock the window beside the I
- select Environment Tab
- P, Assets, SkyBox; drag SkyBox into I, SkyBox Material
- create a Reflection Probe in H; 
    - Position: 0 1.3 0
    - Type: Baked (mine was)
    - [Bake]
    - Position: 0 5 0
    - move the Reflection Probe into _Environment

# Installing XR Interaction Toolkit
- [link](https://academy.zenva.com/lesson/installing-xr-interaction-toolkit-26937f7ceeea36/)
- Window - Package Management - Package Manager
- Unity Registry
    - provides a long list of packages that unity offers
    - Search for XR Inter
- and don't install that
- instead, look for VR.
    - it has 3 packages
    - one of the packages is XR Interaction
    - [Install]
    - I got a signature error, specifically on XR Legacy Input Helpers
    - no idea what that means, but Manage and Remove? Nope. Dependencies.
- select XR Interaction Toolkit
    - find Samples panel
    - Starter Assets [Import]
- I got a Project Validation. So Fix All

- ok, back to Scene
- Move H, Main Camera, Position: 0, 1.25, -0.3
- Edit - Project Settings - XR Plug-In Management
    - select Oculus and OpenXR 
- Restart

## SIDE BAR BEGINS
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
- so, this is painful
- installing 6000.3.8f1
- fix up the VR package import
- (sigh, probably would have been easier to start over)
## SIDE BAR ENDS
- P, Assets, Settings, click PC_Renderer
- [ ] Screen Space Ambient Occlusion   (disable for VR, too much processor cost)
- connect headset, press play, and wonder why it didn't work :-)
- well, sorta worked, static position is sorta nauseating
- but author knows and is working on it - next lesson
- oh, as an aside, I use Virtual Desktop Streamer. It works.


# XR Rig - Part 1
- in H, select Camera
    - in I, new component, "tracked pose driver (Input System)"
    - Position Input, select +, add binding
         - double click <No Binding>, Path, XR HMD, centerEyePosition
    - Rotation Input, select +, add binding
         - double click <No Binding>, Path, XR HMD, deviceRotation         
    - Tracking State Input, select +, add binding
         - double click <No Binding>, Path, XR HMD, trackingState        
- H, create empty, rename XR Origin, Position 0 0 0
- drag Main Camera into XR Origin
    - Position: 0 1.2 0
- H, XR Origin, create empty, rename Left Hand
    - add component tracked pose driver (input system)
    - Position Input, select +, add binding
         - double click <No Binding>, Path, XR Controller, XR Controller(Left Hand), device Position
    - Rotation Input, select +, add binding
         - double click <No Binding>, Path, XR Controller, XR Controller(Left Hand), device Rotation
    - Tracking State Input, select +, add binding
         - double click <No Binding>, Path, XR Controller, XR Controller(Left Hand), tracking State Rotation

- right click H, XR Origin, LeftHand. Add 3D, sphere, rename to HandModel, disable collider, 0.1 scale

- select H, XR Origin, Main Camera
    - Projection, Clipping Planes Near: 0.01 (which is 0)
- Repeat what we did got Left hand, but for right hand
- and test

# XR Rig - Part 2

- verify that we did right hand correctly (we did)
- next, select XR Origin in H
    - Add Component; XR Origin
    - on H, create empty, rename Camera Offset, Position 0 1.35 0
    - set the Main Camera as a child, Position 0 0 0
- select XR Origin
    - assign "that" as Camera Floor offset. (Camera Offset)
    - assign Main Camera as Camera
    - Camera Y Offset: 1.35
    - (note: positions will vary based on head set and wearer)

# Quiz

### 1. What is the most efficient way to persistently assign materials to a 3D model with multiple material slots?

   [O] Dragging the material onto the object in the Scene View.
   [X] Assigning materials in the model's Inspector under the Materials tab.
   [O] Writing a custom Material organizer script.
   [O] Applying materials only to the parent GameObject.

### 2. What is the main function of the Reflection Probe in a Unity scene?
   [O] To calculate dynamic real-time shadows.
   [O] To reduce the polygon count of complex models.
   [X] To capture a 360-degree image of the scene and apply realistic reflections to nearby surfaces.
   [O] To serve as the anchor point for teleportation.

### 3. Which component translates physical movement data from the XR device to update a virtual GameObject’s position and rotation?
   [O] Global Volume
   [O] XR Origin
   [O] Directional Light
   [X] Tracked Pose Driver

### 4. Enabling plugins (like Oculus or OpenXR) in XR Plugin Management serves what core purpose?
   [O] It determines the size of the imported Starter Assets.
   [X] It specifies which VR hardware platforms Unity should communicate with and support.
   [O] It automatically adjusts the Camera's Near Clipping Plane.
   [O] It manages non-VR keyboard and mouse input.

### 5. The Project Validation tool optimizes project settings for high-performance VR by identifying and fixing required configurations.
   [X] True
   [O] False

### 6. Why is the Main Camera’s Near Clipping Plane adjusted to a very small value in a VR setup?
   [O] To improve overall scene frame rate.
   [O] To correctly register the player's height.
   [O] To utilize the Reflection Probe data better.
   [X] To ensure that nearby objects do not get clipped when close to the player's face.

### 7. What is the main architectural role of the XR Origin component on the root player GameObject?
   [X] It acts as a high-level manager, defining central player settings and key references.
   [O] It is solely responsible for reading the headset's positional data.
   [O] It prevents unwanted physics collisions for the controller models.
   [O] It manages the visual display quality.

# Grab Interactables - Part 1
- P, Models; drag the Pot into H
- Pot, Position: -0.14 0.802 0.6 (so its on the counter)
- rename Pot to Model
- create Empty, rename to Pot
- drag Model into Pot
- Pot, Model should be at 0 0 0
- Pot Position at -0.14 0.802 0.6 (so its on the counter)
- Pot, Model; add mesh collider, [x] convex
- OR, remove that, and use two colliders
    - Box Collider 1, resize to fit the pot
    - Box Collider 2, resize to fit the handle
- comment: the two box collider approach is a massive pain in the ass to set up
- practice practice practice!
- select H, Pot
    - add component : RigidBody
    - Is Kinematic [x]
    - add component: XR Grab Interactable
- H, right click, XR, Interaction Manager
    - drag to just under the SampleScene in H (so drag to top)
- H, Pot
    - drag XR Interaction Manager into Interaction Manager (optional? unity will figure it out? hmm)
    - leave the Layer mask as default for now
    - leave Colliders empty for now, unity will figure it out (??)
- H, XR Origin, Left Hand; rclick, XR ... note the type of  Interactors... Direct Interactor for grab
    - Position: 0 0 0 
    - assign (or don't if you trust unity) Interaction Manager
    - set Handedness: Left
    - observe Input Configuration; author discusses select (grip) vs activate (trigger)
    - click top Select Input picker, search XRI Left Interaction/Select
    - click bottom Select Input picker, search XRI Left Interaction/Select Value
    - click top Activate Input picker, search XRI Left Interaction/Activate
    - click bottom Activate Input picker, search XRI Left Interaction/Activate Value
- select H, XR Origin
    - add component, Input Action Manager
    - add element to Action Assets
    - make element XRI Default Input Actions
- test, should have left hand functionality
- now (you guessed it) do the same thing for the right hand
### Challenge: add right hand
- H, XR Origin, Left Hand; rclick, XR ... note the type of  Interactors... Direct Interactor for grab
    - Position: 0 0 0 
    - assign (or don't if you trust unity) Interaction Manager
    - set Handedness: Right
    - observe Input Configuration; author discusses select (grip) vs activate (trigger)
    - click top Select Input picker, search XRI Right Interaction/Select
    - click bottom Select Input picker, search XRI Right Interaction/Select Value
    - click top Activate Input picker, search XRI Right Interaction/Activate
    - click bottom Activate Input picker, search XRI Right Interaction/Activate Value
- Test run; um, no gravity on pot, also can't be dropped. Maybe this is OK?


# Grab Interactables - Part 2
- watching the author demo; matches my experience, no gravity on the pot
- select H, Pot
     - Attach Transform:  { currently none, so it grabs at 0 0 0 of pot)
- in H, Pot, create empty, rename AttachTransform 
     - Position: (up to the handle) say, 0.25 0.1 0
     - Rotation: 0 -90 0
- select H, Pot
     - drag the AttachTransform  into AttachTransform
- test, not is snaps to the AttachTransform on pickup
- ok, if you want to grab it wherever you click, Use Dynamic Attach [x]
- on H, create empty object called Watermelon 
- drag in P, Assets, Models, Watermelon into H, Watermelon
     - rename to be Model
     - Position 0 0 0, 
- Move "it over here" (H, Watermelon) to Position: 0.5 0.831 0.62
- in H, Watermelon, Model
     - I, Materials, ELement0, search and find watermelon material
     - add component Mesh collider, enable convex
- on H, Watermelon
     - add RigidBody component, Is Kinematic [x] (for now)
     - add component, XR Grab Interactable
     - Use Dynamic Attach

# Physical Environment
- select H, _Environment, Platform
     - add component Mesh Collider
- select H, Kitchen, CounterTop
     - add component Mesh Collider
- select H, Kitchen, ChoppingBoard
     - add component Box Collider
- select H, Kitchen, Base
     - add component Mesh Collider
- select H, Kitchen, Faucet
     - add component Mesh Collider
- select H, Kitchen, FaucetHandle
     - add component Mesh Collider
- select H, Kitchen, Sink
     - add component Mesh Collider
- select H, Pot
     - Disable Is Kinematic
- select H, Watermelon
     - Disable Is Kinematic
- notes: the Pot and Watermelon will now drop. They will collide with items above

# Ray Interactor
- like a ray that you can point and "interact" with objects
- rclick: H, XROrgin, LeftHand, XR-RayInteractor
- select H, XROrgin, LeftHand, XR-RayInteractor
     - Handedness: Left
     - UI Interaction [ ]   (for now)
     - Translate Input (how close/far to move object): XRI Left Interaction/Translate Manipulation
     - Rotate Input: XRI Left Interaction/Rotate Manipulation
     - Directional Input, Scale Toggle Input and Scale Over Time Input;  leave as None
     - scroll down to Input Configuration
     - Select Input top: XRI Left Interaction/Select
     - Select Input bottom: XRI Left Interaction/Select Value
     - Activate Input top: XRI Left Interaction/Activate
     - Activate Input bottom: XRI Left Interaction/Activate Value
- test, should be able to point, grip, and move in and out (joy) and ungrip and drop
- BUG: my watermelon was not working correctly. I went back and redid it, works now.
     - (basically I put rigidbody on the model instead of the watermelon)
- BUG: my pot is dropping a pixel to deep into things
     - so the box collider on the pot needed to be stretched on the Y
     - Vector3(0.24629952,0.133671463,0.24000001)
- H XR Origin, Left Hand, Ray Indicator
     - Force Grab [x]  ( will cause objects to snap to your hand position)
     - test that
     - Width Curve
     - Colors: lose the gradients and go green for valid, blue for invalid
     - (leave blocked alone)
- Tested, everything is working (hazzah)
- Next, challenge is to do all this again for the right hand
- I just copied Ray Interactor on Left over to Right, and changed stuff.
- Test, seems to work

# Faucet Interaction
- create H, Empty Object - rename FaucetInteraction
     - for now, drag up in general vicinity of Faucet
     - add a box collider to the FaucetInteraction
     - Position: 0.0586 0.887 1.3833
     - Rotation: 0 0 0
     - Scale: 1 1 1
     - Center: 0 0 0
     - Size: 0.04406889 0.1203088 0.08518425
     - add a XR Simple Interactable  (triggers if interacted with)
     - assign collider 
- P, Assets, Water Particle; drag WaterParticle prefab into H
     - "align it right about here" Position: 0 0.9779 1.0733
     - Play on Awake [ ]
- P, Assets create folder called Scripts
     - cresate new script Faucet
- H, FaucetInteraction
     - drag script in
- open script in Visual Studio
- delete Start and Update methods; we don't need them
<pre>
using UnityEngine;

public class Faucet : MonoBehaviour
{
    private bool isOn;

    [SerializeField]
    private Transform tapObject;
    [SerializeField]
    private Vector3 offRotation;
    [SerializeField]
    private Vector3 onRotation;
    [SerializeField]
    private ParticleSystem waterParticle;

    private void Start()
    {
        TurnOff();
    }
    public void Toggle()
    {
        if (isOn)
        {
            TurnOff();
        }
        else
        {
            TurnOn();
        }
    }
    void TurnOn()
    {
        isOn = true;
        waterParticle.Play();
        tapObject.localEulerAngles = onRotation;
    }
    void TurnOff()
    {
        isOn = false;
        waterParticle.Stop();
        tapObject.localEulerAngles = offRotation;
    }
}
</pre>
- save, unity
- Lock
- select H, Kitchen, FaucetHandle drag into Tab Object
- Off Rotation 0 0 0
- On Rotation 0 0 40
- select H, WaterParticle drag into Water Particle
- UnLock
- Select Entered ; +
- drag in Faucet script
- select Toggle


# Quiz

###1. Which component allows a GameObject to be picked up and held by a user?

    [ ] XR Simple Interactable
    [ ] Rigidbody
    [X] XR Grab Interactable
    [ ] Input Action Manager
    [ ] XR Direct Interactor

###2. To be physically interactive, an object requires both a Collider and a Rigidbody component.
    [X] True
    [ ] False

###3. Which interactor component is used primarily for near-field interaction (grabbing by touching)?
    [ ] XR Ray Interactor
    [ ] XR Interactor Line Visual
    [ ] XR Grab Interactable
    [X] XR Direct Interactor

###4. If a Rigidbody has the Is Kinematic property enabled, the object is controlled by the physics engine and affected by gravity.
    [ ] True
    [X] False

###5. To define a fixed location (e.g., a handle) where the hand snaps when grabbing an object, which XR Grab Interactable property is used?
    [X] Attach Transform
    [ ] Select Action
    [ ] Use Dynamic Attach
    [ ] Rigidbody

###6. The Use Dynamic Attach property is ideal for tools or weapons that require a fixed, specific grab point (e.g., a handle)
    [ ] True
    [X] False

###7. What is the primary function of the XR Ray Interactor?
    [ ] Manipulating UI elements only
    [X] Ranged interaction (pointing at distant objects)
    [ ] Near-field interaction based on collision
    [ ] Defining an object’s custom grab rotation

###8. Static environment objects (like the floor) that block physics-enabled items require an XR Grab Interactable component.
    [ ] True
    [X] False

###9. Which component is required in the scene to manage and coordinate all controller input actions (like Select and Activate)?
    [ ] XR Origin
    [ ] Interaction Manager
    [X] Input Action Manager
    [ ] Rigidbody

###10. The XR Simple Interactable component is used for triggering events rather than for pick-up and hold mechanics.
    [X] True
    [ ] False


# Locomotion
- select H, XR Origin
    - add component Character Controller
    - Radius: 0.1
    - Height: 1.35 (match the camera height)
    - X: 0  Y: 1.35/2 Z: 0
- select H, XR Origin; create empty game object rename to Locomotion
    - add component Locomotion Mediator
    - it will automatically find XR Origin
    - make sure Use Character Controller [x]  (it should be)
- select H, XR Origin, Locomotion; create empty rename Move
    - add component Continuous Move Provider
    - drag Locomotion into Mediator
    - Forward Source: (drag in) Main Camera
    - Left Hand Move Input: XRI Left Locomotion/Move
    - Right Hand Move Input: None  (no movement on right hand)
- save, press play
- select H, XR Origin, Locomotion; create empty rename Turn
    - add component Snap Turn Provider
    - drag Locomotion into Mediator
    - note this one turns you in 45degree snaps (configurable)
    - Left Hand Turn: None
    - Right Hand Turn Input: XRI Right Locomotion/Snap Turn


    - add component Continuous Turn Provider
    - drag Locomotion into Mediator
    - Left Hand Turn: None
    - Right Hand Turn Input: XRI Right Locomotion/Turn
 
    - YOU CANNOT USE BOTH, SO DEACTIVATE ONE
    - disable Continuous for now


# Quiz

###1. What is the main role of the Character Controller component when added to the XR Origin for VR locomotion?

    [ ] To enable full Rigidbody physics simulation.
    [ ] To set the maximum speed for continuous turning.
    [ ] To define the camera offset height.
    [X] To provide a simple physical presence (collider) for collision without relying on full physics.

###2. Which component serves as the central manager coordinating all Locomotion Providers and the Character Controller?

    [ ] Continuous Move Provider
    [ ] XR Origin
    [X] Locomotion Mediator
    [ ] Input Action Manager

###3. To ensure the player moves in the direction they’re looking, which object is typically assigned to the Continuous Move Provider’s “Forward Source” property?

    [ ] The Character Controller GameObject
    [X] The Main Camera
    [ ] The Locomotion Mediator
    [ ] The Collider component

###4. Snap Turning is commonly preferred over Continuous Turning because it helps mitigate motion sickness for many users.

    [X] True
    [ ] False

###5. In the standard XR input setup, what function is assigned to the input action reference for the left-hand joystick?

    [ ] Managing rotational speed for turning.
    [ ] Triggering snap rotation.
    [X] Handling forward, backward, and sideways translation (movement).
    [ ] Activating the comfort vignette effect.




# Course Conclusions

- very introductory
- no C# experience is necessary for this course
- no discussion of setup (which is fine, but not beginner level)


# ----- beyond this point is not in the course -----
- and for the record, it should have been.

# Add a UI

## Create the Canvas
- rclick H; UI(Canvas), Canvas  (adds a canvas)
- double click the H, Canvas
- switch to 2D (its a button on the Scene)
- rclick H, Canvas; UI, Panel (add a Panel to Canvas, gives us a grey background)
- rclick H, Canvas; UI, Text-TextMeshPro
     - click to accept TMP essentials, then close, if first time
     - observe that an EventSystem is added to your H
- select H, Canvas, Text
     - set Text: Example UI
     - use alignment icons to center verti and hori
     - Font Size: 66
     - Position: -6.5 188 0
     - Width: 1064 Height: 190
     - (so move it to the top, stretch to fit the space basically)
- rclick H, Canvas; UI, Button-TextMeshPro
- select H, Canvas, Button, Text
     - Font Size: 46
- select H, Canvas, Button
     - Resize to fit the text (Width: 200  Height: 65 works)
     - move to a nice position (-20 33 0 works)
- rclick H, Canvas; UI, Scrollbar
     - move below button (-20 -500 0 works)
     - make it bigger, say width 550 Height: 45

## Position Canvas in 3D space
- select H, Canvas
     - Render Mode: World Space
     - Scale: 0.001 0.001 0.001  
     - Position: 0 0 0    (for now)
- exit 2D space (so click the 2D icon again)
- double click the H, Canvas
- reposition the Canvas in Scene to someplace better
     - Position: 2 1.5 1.3   (so long as you will see it while in VR)

## Hook up Ray Interactor
- note: we have one from previous work for manipulating objects
- we will add functionality to right hand only
- select XR Origin, Right Hand, Ray Interactor
     - make sure UI Interaction [X] (it should be already)
     - UI Pressed has three (3) items to setup
     - Item one: XRI Right Interaction/UI Press
     - Item two: XRI Right Interaction/UI Press Value
     - Item two: XRI Right Interaction/UI Scroll
- you could do the same on the Left Hand if you liked, just use Left Interactions


## Connect VR Clicks to EventSystem
- select H, EventSystem
- observe the Input System UI Module; it allows working with mouse.
- disable it  (hmm, can I have both? experiment later maybe)
- add component XR UI Input Module
- find the doohicky with the lines and adjuster bars beside the name of the component
- looks like:
<pre>
----|-
--|---
</pre>
- click it to bring up a preset list, select 
<pre>
Assets/samples/XR Interaction Toolkit/3.2.1/Starter Assets/Presets/XRI Default XR UI Input Module.preset
</pre>
- observe that filled in a bunch of UI Actions for us 
- select H, Canvas
     - add component Tracked Device Graphic RayCaster
- this should be enough to get use started; save and test in VR

## Connect Button to code
- add a script, call it UIManager
- P, Assets, Scripts; new MonoBehaviourScript, rename UIManager
- hmm, lets drag that script into H,Canvas
- doubleclick I, UI ManagerScript, Script UIManager
- add a method:
<pre>
    public void ButtonClicked()
    {
        Debug.Log("UIManager::ButtonClicked was called.");
    }
</pre>
- this should print out a message when the button was clicked.
- save, unity
- select H, Canvas, Button
    - On Click() press +
    - drag Canvas into Object  (since thats where we attached the script)
    - Function drag it to UIManager.ButtonClicked
- save, run - if you click the button, you will get a message logged to Console


## Connect the Slider
- the slider has a variable called Value we want to display in Console
- there is an On Value Changed event we can connect to 
- open the H, Canvas; UIManager script
<pre>
    [SerializeField]
    private Scrollbar scrollbar;
</pre>
- (we will assign this to the scrollbar in the unity editor)
- (also, I see some people using "public Scrollbar scrollbar". This works too, but is weaksauce)
<pre>
    public void ScrollbarChanged()
    {
        float value = (scrollbar?scrollbar.value: -1.0f);
        Debug.Log("UIManager::ScrollbarChanged was called with a value of " 
            + value.ToString("F2"));
    }
</pre>
- (I used a ternary to check if scrollbar had been set; not really necessary, I suppose)
- save, unity
- select H, Canvas
- drag H,Canvas,Scrollbar into Scrollbar
- select H, Canvas, Scrollbar
     - On Value Changed  press +
     - Runtime (fine)
     - None(Object) -> Canvas
     - No Function -> UIManager.ScrollbarChanged
- save, run, move the slider to half, 100, and back to 0. See console.
- console will have a LOT of values displayed, ranged from 0.0 to 1.0

## Lets display slider value "dynamically"
- double click H, Canvas
- click the 2D icon on the scence
- rclick H, Canvas; UI, Text
     - put this beside your slider (Position 385, -100, 0 works for me)
     - set the Text to 0.0
     - we could make it bold, black, etc. 
     - we can hori and verti center is by pressing icons
     - rename this from Text to ScrollBarValueText
- open the H, Canvas; UIManager script
- add accessor
<pre>
    [SerializeField]
    private TMP_Text scrollBarValueText;
</pre>
- (you don't have to use the same name as unity IDE, just convience)
- lets initially blank this:
<pre>
    void Start()
    {
        scrollBarValueText.text = string.Empty;
    }
</pre>
- then in update (called every frame)
<pre>
 void Update()
 {
     
     scrollBarValueText.text = (scrollbar ? scrollbar.value : -1.0f).ToString("F2");
 }
</pre>
- save, unity
- drag ScrollBarValueText into Scroll Bar Value Text
- save, run.  As you drag the scrollbar nub around, the value changes on the screen.











