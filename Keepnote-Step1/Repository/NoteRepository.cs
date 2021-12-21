using System.Collections.Generic;
using Keepnote_Step1.Models;
using System.Linq;

namespace Keepnote_Step1.Repository
{
      /*
      This class contains the code for data storage interactions and methods 
      of this class will be used by other parts of the applications such
      as Controllers and Test Cases
      */
    public class NoteRepository : INoteRepository
    {

        /* Declare a variable of List type to store all the notes. */
        public List<Note> NoteList;

        public NoteRepository()
        {
            /* Initialize the variable using proper data type */
            NoteList = new List<Note>();
            
        }

        /* This method should return all the notes in the list */
        public List<Note> GetNotes()
        {
            return NoteList;
        }

        /*
	        This method should accept Note object as argument and add the new note object into  list
	    */
        public void AddNote(Note note)
        {
            NoteList.Add(note);
        }

        /* This method should deleted a specified note from the list */
        public bool DeletNote(int noteId)
        {
            bool notePresent = Exists(noteId);
            if (notePresent)
            {
                Note note = NoteList.Where(x => x.NoteId == noteId).FirstOrDefault();
                NoteList.Remove(note);
                return true;
            }
            else
                return false;
        }

        /*
	      This method should check if the matching note id present in the list or not.
	      Return true if note id exists in the list or return false if note id does not
	      exists in the list
	  */
        public bool Exists(int noteId)
        {
            int index = NoteList.FindIndex(x => x.NoteId == noteId);

            if (index==0)
                return true;
            else
                return false;
                                  
        }
    }
}
