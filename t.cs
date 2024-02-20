public class Test
{
	public bool Enabled
    {
		
        get

        {

            return this.enabled;
        }
    }
	
	public virtual ActionResult Claim(PageContext contex)
	{
		if (context.CanBeClaimed)
		{
			
		}

		return new EmptyResult();
	}
}
