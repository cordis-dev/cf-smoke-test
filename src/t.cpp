// should not report whitespace/end_of_line
// should report whitespace/empty_if_body
size_t TF_DataTypeSize(TF_DataType dt) { 
  return static_cast<size_t>(
	if (true)
	{
	}
	
    tensorflow::DataTypeSize(static_cast<DataType>(dt)));
}
