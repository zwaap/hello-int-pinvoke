int m_value;

extern "C" int hello_int_get_value()
{
	return m_value;
}

extern "C" void hello_int_set_value(int val)
{
	m_value = val;
}
