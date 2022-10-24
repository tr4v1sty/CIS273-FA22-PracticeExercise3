using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise3
{
	public interface IQueue<T>
	{
		T Dequeue();

		T First {get;}
		T Last {get;}

	}
}

