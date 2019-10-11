using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;

public class Keyboard : MonoBehaviour
{

    public InputField TextField;
    public InputField JoinRoom;
    public InputField PlayerName;

    public SteamVR_LaserPointer laserPointer;
    string alphabet;

    public bool Room;
    public bool Join;
    public bool PlayerNameCheck;

    void Awake()
    {
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "A")
        {
            Debug.Log("A was clicked");
            A();
        }
        else if (e.target.name == "B")
        {
            Debug.Log("B was clicked");
            B();
        }
        else if (e.target.name == "C")
        {
            Debug.Log("C was clicked");
            C();
        }
        else if (e.target.name == "D")
        {
            Debug.Log("D was clicked");
            D();
        }
        else if (e.target.name == "E")
        {
            Debug.Log("E was clicked");
            E();
        }
        else if (e.target.name == "F")
        {
            Debug.Log("F was clicked");
            F();
        }
        else if (e.target.name == "G")
        {
            Debug.Log("G was clicked");
            G();
        }
        else if (e.target.name == "H")
        {
            Debug.Log("H was clicked");
            H();
        }
        else if (e.target.name == "I")
        {
            Debug.Log("I was clicked");
            I();
        }
        else if (e.target.name == "J")
        {
            Debug.Log("J was clicked");
            J();
        }
        else if (e.target.name == "K")
        {
            Debug.Log("K was clicked");
            K();
        }
        else if (e.target.name == "L")
        {
            Debug.Log("L was clicked");
            L();
        }
        else if (e.target.name == "M")
        {
            Debug.Log("M was clicked");
            M();
        }
        else if (e.target.name == "N")
        {
            Debug.Log("N was clicked");
            N();
        }
        else if (e.target.name == "O")
        {
            Debug.Log("O was clicked");
            O();
        }
        else if (e.target.name == "P")
        {
            Debug.Log("P was clicked");
            P();
        }
        else if (e.target.name == "Q")
        {
            Debug.Log("Q was clicked");
            Q();
        }
        else if (e.target.name == "R")
        {
            Debug.Log("R was clicked");
            R();
        }
        else if (e.target.name == "S")
        {
            Debug.Log("S was clicked");
            S();
        }
        else if (e.target.name == "T")
        {
            Debug.Log("T was clicked");
            T();
        }
        else if (e.target.name == "U")
        {
            Debug.Log("U was clicked");
            U();
        }
        else if (e.target.name == "V")
        {
            Debug.Log("V was clicked");
            V();
        }
        else if (e.target.name == "W")
        {
            Debug.Log("W was clicked");
            W();
        }
        else if (e.target.name == "X")
        {
            Debug.Log("X was clicked");
            X();
        }
        else if (e.target.name == "Y")
        {
            Debug.Log("Y was clicked");
            Y();
        }
        else if (e.target.name == "Z")
        {
            Debug.Log("Z was clicked");
            Z();
        }
        else if (e.target.name == "Coma")
        {
            Debug.Log("Coma was clicked");
            Coma();
        }
        else if (e.target.name == "FullStop")
        {
            Debug.Log("FullStop was clicked");
            FullStop();
        }
        else if (e.target.name == "BackSpace")
        {
            Debug.Log("BackSpace was clicked");
            BackSpace();
        }
        else if (e.target.name == "Space")
        {
            Debug.Log("Space was clicked");
            Space();
        }
        else if (e.target.name == "1")
        {
            Debug.Log("1 was clicked");
            One();
        }
        else if (e.target.name == "2")
        {
            Debug.Log("2 was clicked");
            Two();
        }
        else if (e.target.name == "3")
        {
            Debug.Log("3 was clicked");
            Three();
        }
        else if (e.target.name == "4")
        {
            Debug.Log("4 was clicked");
            Four();
        }
        else if (e.target.name == "5")
        {
            Debug.Log("5 was clicked");
            Five();
        }
        else if (e.target.name == "6")
        {
            Debug.Log("6 was clicked");
            Six();
        }
        else if (e.target.name == "7")
        {
            Debug.Log("7 was clicked");
            Seven();
        }
        else if (e.target.name == "8")
        {
            Debug.Log("8 was clicked");
            Eight();
        }
        else if (e.target.name == "9")
        {
            Debug.Log("9 was clicked");
            Nine();
        }
        else if (e.target.name == "0")
        {
            Debug.Log("0 was clicked");
            Zero();
        }

        if (e.target.name == "RoomNameInput")
        {
            TextField.ActivateInputField();
            JoinRoom.DeactivateInputField();

            if (TextField.isActiveAndEnabled == true)
            {
                Debug.Log("Join Room is deactive  " + JoinRoom.isActiveAndEnabled);
                Debug.Log("Room Name Input Activated" + TextField.isActiveAndEnabled);
                Debug.Log("Room Name is enable" + (TextField.enabled == true));
                Room = true;
                Join = false;
            }
        }
        else if (e.target.name == "JoinRoomInput")
        {
            JoinRoom.ActivateInputField();
            TextField.DeactivateInputField();

            if (JoinRoom.isActiveAndEnabled == true)
            {
                Debug.Log("Room Name is deactive = " + TextField.isActiveAndEnabled);
                Debug.Log("Join Room Input Activated" + JoinRoom.isActiveAndEnabled);

                Room = false;
                Join = true;
            }
        }
        else if (e.target.name == "PlayerName")
        {
            PlayerName.ActivateInputField();

            if (PlayerName.isActiveAndEnabled == true)
            {
                Debug.Log("Player Name Activated!");

                PlayerNameCheck = true;
                Room = false;
                Join = false;
            }
        }
    }


    public void A()
    {

        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "A";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "A";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "A";
        }
    }

    public void B()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "B";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "B";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "B";
        }
    }

    public void C()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "C";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "C";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "C";
        }
    }

    public void D()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "D";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "D";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "D";
        }
    }

    public void E()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "E";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "E";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "E";
        }
    }

    public void F()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "F";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "F";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "F";
        }
    }

    public void G()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "G";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "G";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "G";
        }
    }

    public void H()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "H";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "H";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "H";
        }
    }

    public void I()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "I";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "I";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "I";
        }
    }

    public void J()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "J";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "J";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "J";
        }
    }

    public void K()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "K";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "K";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "K";
        }
    }

    public void L()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "L";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "L";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "L";
        }
    }

    public void M()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "M";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "M";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "M";
        }
    }

    public void N()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "N";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "N";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "N";
        }
    }

    public void O()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "O";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "O";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "O";
        }
    }

    public void P()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "P";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "P";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "P";
        }
    }

    public void Q()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "Q";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "Q";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "Q";
        }
    }

    public void R()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "R";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "R";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "R";
        }
    }

    public void S()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "S";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "S";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "S";
        }
    }

    public void T()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "T";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "T";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "T";
        }
    }

    public void U()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "U";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "U";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "U";
        }
    }

    public void V()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "V";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "V";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "V";
        }
    }

    public void W()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "W";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "W";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "W";
        }
    }

    public void X()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "X";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "X";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "X";
        }
    }

    public void Y()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "Y";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "Y";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "Y";
        }
    }

    public void Z()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "Z";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "Z";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "Z";
        }
    }

    public void FullStop()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + ".";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + ".";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + ".";
        }
    }

    public void Coma()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + ",";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + ",";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + ",";
        }
    }

    public void BackSpace()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            if (TextField.text.Length > 0) TextField.text = TextField.text.Remove(TextField.text.Length - 1);
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            if (JoinRoom.text.Length > 0) JoinRoom.text = JoinRoom.text.Remove(JoinRoom.text.Length - 1);
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            if (PlayerName.text.Length > 0) PlayerName.text = PlayerName.text.Remove(PlayerName.text.Length - 1);
        }
    }

    public void Space()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + " ";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + " ";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + " ";
        }
    }

    public void One()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "1";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "1";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "1";
        }
    }

    public void Two()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "2";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "2";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "2";
        }
    }

    public void Three()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "3";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "3";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "3";
        }
    }
    public void Four()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "4";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "4";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "4";
        }
    }
    public void Five()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "5";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "5";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "5";
        }
    }
    public void Six()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "6";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "6";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "6";
        }

    }
    public void Seven()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "7";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "7";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "7";
        }
    }
    public void Eight()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "8";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "8";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "8";
        }
    }
    public void Nine()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "9";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "9";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "9";
        }
    }
    public void Zero()
    {
        if (Room == true && Join == false && PlayerNameCheck == false)
        {
            TextField.text = TextField.text + "0";
        }
        else if (Join == true && Room == false && PlayerNameCheck == false)
        {
            JoinRoom.text = JoinRoom.text + "0";
        }
        else if (PlayerNameCheck == true && Room == false && Join == false)
        {
            PlayerName.text = PlayerName.text + "0";
        }
    }

}