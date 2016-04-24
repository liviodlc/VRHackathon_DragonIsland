using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Content
{

	public static void initContent (Player player, Room startingRoom)
	{
		Room r1 = startingRoom;
		Ball ball = new Ball ();

		Room r2 = new Room ();
		Ball b2 = new Ball ();

		Room r3 = new Room ();
		Room r4 = new Room ();
		Room r5 = new Room ();
		Room r6 = new Room ();
		Room r7 = new Room ();
		Room r8 = new Room ();
		Room r9 = new Room ();

		Room r10 = new Room ();
		Room r11 = new Room ();
		Room r12 = new Room ();
		Room r13 = new Room ();
		Room r14 = new Room ();
		Room r15 = new Room ();
		Room r16 = new Room ();
		Room r17 = new Room ();
		Room r18 = new Room ();
		Room r19 = new Room ();
		Room r20 = new Room ();

		Room r21 = new Room ();
		Room r22 = new Room ();
		Room r23 = new Room ();
		Room r24 = new Room ();
		Room r25 = new Room ();
		Room r26 = new Room ();
		Room r27 = new Room ();
		Room r28 = new Room ();
		Room r29 = new Room ();
		Room r30 = new Room ();

		Room r31 = new Room ();
		Room r32 = new Room ();
		Room r33 = new Room ();
		Room r34 = new Room ();
		Room r35 = new Room ();
		Room r36 = new Room ();
		Room r37 = new Room ();
		Room r38 = new Room ();
		Room r39 = new Room ();
		Room r40 = new Room ();


		Room r41 = new Room ();
		Room r42 = new Room ();
		Room r43 = new Room ();
		Room r44 = new Room ();
		Room r45 = new Room ();
		Room r46 = new Room ();
		Room r47 = new Room ();
		Room r48 = new Room ();
		Room r49 = new Room ();
		Room r50 = new Room ();

		Dragon d1 = new Dragon ();
		Chest c1 = new Chest ();


	
		//-----Column 1
		//Room 1
		//r1.setExit (Direction.North, r8);
		//r1.setExit (Direction.West, r);
		//r1.setExit (Direction.South, r);
		r1.setExit (Direction.East, r2);

		r1.addItem (ball);
		r1.addDragon (d1);
		r1.addItem (c1);

		//Room2
		//r1.setExit (Direction.North, r8);
		r1.setExit (Direction.West, r1);
		//r1.setExit (Direction.South, r);
		r1.setExit (Direction.East, r3);
		r2.addItem (b2);

		//Room3
		r3.setExit (Direction.North, r10);
		r3.setExit (Direction.West, r2);
////	r3.setExit (Direction.South, r);
		r3.setExit (Direction.East, r4);
//
//		//Room4
//		r4.setExit (Direction.North, r11);
		r4.setExit (Direction.West, r4);
//		r4.setExit (Direction.South, r);
		r4.setExit (Direction.East, r5);
//
//		//Room5
		r5.setExit (Direction.North, r12);
		r5.setExit (Direction.West, r4);
//		r5.setExit (Direction.South, r);
		r5.setExit (Direction.East, r6);
//
//		//Room6
//		r6.setExit (Direction.North, r13);
		r6.setExit (Direction.West, r5);
//		r6.setExit (Direction.South, r);
		r6.setExit (Direction.East, r7);
//

//		//Room7
		r7.setExit (Direction.North, r14);
		r7.setExit (Direction.West, r6);
//		r7.setExit (Direction.South, r);
//		r7.setExit (Direction.East, r);



		////---Row 2
//		//Room8
//		r8.setExit (Direction.North, 15r);
//		r8.setExit (Direction.West, r);
//		r8.setExit (Direction.South, r1);
		r8.setExit (Direction.East, r9);
//
//		//Room9
		r9.setExit (Direction.North, r16);
		r9.setExit (Direction.West, r8);
//		r9.setExit (Direction.South, r2);
		r9.setExit (Direction.East, r10);
//
//		//Room10
//		r10.setExit (Direction.North, r17);
//		r10.setExit (Direction.West, r9);
		r10.setExit (Direction.South, r3);
		r10.setExit (Direction.East, r11);

//		//Room11
		r11.setExit (Direction.North, r18);
//		r11.setExit (Direction.West, r10);
//		r11.setExit (Direction.South, r4);
		r11.setExit (Direction.East, r12);
//
//		//Room12
//		r12.setExit (Direction.North, r19);
		r12.setExit (Direction.West, r11);
		r12.setExit (Direction.South, r5);
//		r12.setExit (Direction.East, r13);
//
//		//Room13
		r13.setExit (Direction.North, r20);
//		r13.setExit (Direction.West, r13);
//		r13.setExit (Direction.South, r6);
		r13.setExit (Direction.East, r14);
//
//		//Room14
//		r14.setExit (Direction.North, r21);
		r14.setExit (Direction.West, r12);
		r14.setExit (Direction.South, r7);
//		r14.setExit (Direction.East, r);


//		--row 3
//
//		//Room15
		r15.setExit (Direction.North, r22);
//		r15.setExit (Direction.West, r);
//		r15.setExit (Direction.South, r);
		r15.setExit (Direction.East, r16);
//
//		//Room16
//		r16.setExit (Direction.North, r);
		r16.setExit (Direction.West, r15);
		r16.setExit (Direction.South, r9);
		r16.setExit (Direction.East, r17);
//
//		//Room17
		r17.setExit (Direction.North, r24);
		r17.setExit (Direction.West, r17);
//		r17.setExit (Direction.South, r);
//		r17.setExit (Direction.East, r);
//
//		//Room18
		r18.setExit (Direction.North, r25);
//		r18.setExit (Direction.West, r);
//		r18.setExit (Direction.South, r);
		r18.setExit (Direction.East, r11);
//
//		//Room19
		r19.setExit (Direction.North, r26);
//		r19.setExit (Direction.West, r);
//		r19.setExit (Direction.South, r);
		r19.setExit (Direction.East, r20);
//
//		//Room20
		r20.setExit (Direction.North, r27);
		r20.setExit (Direction.West, r19);
		r20.setExit (Direction.South, r13);
		r20.setExit (Direction.East, r21);

//		//Room21
		r21.setExit (Direction.North, r28);
		r21.setExit (Direction.West, r20);
//		r21.setExit (Direction.South, r);
//		r21.setExit (Direction.East, r);
//

		//---Row 4

//		//Room22
		r22.setExit (Direction.North, r29);
//		r22.setExit (Direction.West, r);
		r22.setExit (Direction.South, r15);
//		r22.setExit (Direction.East, r);
//
//		//Room23
		r23.setExit (Direction.North, r30);
//		r23.setExit (Direction.West, r);
//		r23.setExit (Direction.South, r);
		r23.setExit (Direction.East, r24);
//
//		//Room24
//		r24.setExit (Direction.North, r);
		r24.setExit (Direction.West, r23);
		r24.setExit (Direction.South, r17);
		r24.setExit (Direction.East, r25);
//
//		//Room25
		r25.setExit (Direction.North, r32);
		r25.setExit (Direction.West, r24);
		r25.setExit (Direction.South, r18);
		r25.setExit (Direction.East, r26);
//
//		//Room26
		r26.setExit (Direction.North, r33);
		r26.setExit (Direction.West, r25);
		r26.setExit (Direction.South, r19);
//		r26.setExit (Direction.East, r);
//
//		//Room27
		r27.setExit (Direction.North, r34);
//		r27.setExit (Direction.West, r);
		r27.setExit (Direction.South, r20);
		r27.setExit (Direction.East, r28);

//		//Room28
//		r28.setExit (Direction.North, r);
		r28.setExit (Direction.West, r27);
		r28.setExit (Direction.South, r21);
//		r28.setExit (Direction.East, r);

//  --Row 5

//		//Room29
		r29.setExit (Direction.North, r36);
//		r29.setExit (Direction.West, r);
		r29.setExit (Direction.South, r22);
		r29.setExit (Direction.East, r30);
//
//		//Room30
		r30.setExit (Direction.North, r37);
		r30.setExit (Direction.West, r29);
		r30.setExit (Direction.South, r23);
//		r30.setExit (Direction.East, r);
//
//		//Room31
		r31.setExit (Direction.North, r38);
//		r31.setExit (Direction.West, r);
//		r31.setExit (Direction.South, r);
//		r31.setExit (Direction.East, r);
//
//		//Room32
		r32.setExit (Direction.North, r30);
//		r32.setExit (Direction.West, r);
		r32.setExit (Direction.South, r25);
		r32.setExit (Direction.East, r33);
//
//		//Room33
		r33.setExit (Direction.North, r40);
		r33.setExit (Direction.West, r34);
		r33.setExit (Direction.South, r26);
		r33.setExit (Direction.East, r34);
//
//		//Room34
//		r34.setExit (Direction.North, r);
		r34.setExit (Direction.West, r33);
		r34.setExit (Direction.South, r37);
		r34.setExit (Direction.East, r35);
//
//		//Room35
		r35.setExit (Direction.North, r42);
		r35.setExit (Direction.West, r34);
//		r35.setExit (Direction.South, r);
//		r35.setExit (Direction.East, r);


		// ----Row 6
//		//Room36
		r36.setExit (Direction.North, r43);
//		r36.setExit (Direction.West, r);
		r36.setExit (Direction.South, r29);
		r36.setExit (Direction.East, r37);
//
//		//Room37
		r37.setExit (Direction.North, r44);
		r37.setExit (Direction.West, r36);
		r37.setExit (Direction.South, r30);
		r37.setExit (Direction.East, r38);
//
//		//Room38
		r38.setExit (Direction.North, r45);
		r38.setExit (Direction.West, r37);
		r38.setExit (Direction.South, r31);
		r38.setExit (Direction.East, r39);
//
//		//Room39
		r39.setExit (Direction.North, r46);
		r39.setExit (Direction.West, r38);
		r39.setExit (Direction.South, r32);
		r39.setExit (Direction.East, r40);
//
//		//Room40
//		r40.setExit (Direction.North, r);
		r40.setExit (Direction.West, r39);
		r40.setExit (Direction.South, r33);
		r40.setExit (Direction.East, r41);

//		//Room41
		r41.setExit (Direction.North, r48);
		r41.setExit (Direction.West, r40);
//		r41.setExit (Direction.South, r);
		r41.setExit (Direction.East, r42);
//

//		//Room42
//		r42.setExit (Direction.North, r);
		r42.setExit (Direction.West, r41);
//		r42.setExit (Direction.South, r);
		r42.setExit (Direction.East, r42);


//Row 6
//		//Room43
//		r43.setExit (Direction.North, r);
//		r43.setExit (Direction.West, r);
		r43.setExit (Direction.South, r36);
//		r43.setExit (Direction.East, r);
//
//		//Room44
//		r44.setExit (Direction.North, r);
//		r44.setExit (Direction.West, r);
		r44.setExit (Direction.South, r37);
		r44.setExit (Direction.East, r45);

	
//		//Room45
//		r45.setExit (Direction.North, r);
		r45.setExit (Direction.West, r44);
		r45.setExit (Direction.South, r38);
//		r45.setExit (Direction.East, r);
//
//		//Room46
//		r46.setExit (Direction.North, r);
//		r46.setExit (Direction.West, r);
		r46.setExit (Direction.South, r39);
		r46.setExit (Direction.East, r47);
//
//		//Room47
//		r47.setExit (Direction.North, r);
		r47.setExit (Direction.West, r46);
//		r47.setExit (Direction.South, r);
		r47.setExit (Direction.East, r48);
//
//		//Room48
//		r48.setExit (Direction.North, r);
		r48.setExit (Direction.West, r47);
		r48.setExit (Direction.South, r41);
		r48.setExit (Direction.East, r49);
//
//		//Room49
//		r49.setExit (Direction.North, r);
		r49.setExit (Direction.West, r48);
//		r49.setExit (Direction.South, r);
//		r49.setExit (Direction.East, r);





//		//Room
//		r.setExit (Direction.North, r);
//		r.setExit (Direction.West, r);
//		r.setExit (Direction.South, r);
//		r.setExit (Direction.East, r);


	}
}